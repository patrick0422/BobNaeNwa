using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BobNaeNwa
{
    // MySqlConnection connection = new MySqlConnection($"Server=localhost;Port=3306;Database=bobnaenwa;Uid=root;Pwd=12341234");
    class Meal
    {
        public int popular;
        public int timing;
        public string menu_name;

        public Meal(int popular, int timing, string menu_name)
        {
            this.popular = popular; this.timing = timing; this.menu_name = menu_name;
        }
    }

    class like_meal
    {
        static MySqlConnection connection = null;
        public static MySqlConnection getConnection()
        {
            if (connection == null)
            {
                connection = new MySqlConnection($"Server=localhost;Port=3306;Database=bobnaenwa;Uid=root;Pwd=12341234");
                return connection;
            }
            else
                return connection;
        }
        public static void CreateTable(MySqlConnection connection)
        {
            string query =
                "create table like_meal(" +
                "idx int auto_increment primary key," +
                "created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP," +
                "timing_idx int," +
                "menu_name char(100)," +
                "foreign key(timing_idx) references timing_list(idx)" +
                ");";

            try//예외 처리
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                Console.WriteLine(command.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void Insert(string timing_idx, string menu_name, MySqlConnection connection)
        {
            string query = $"INSERT INTO like_meal(timing_idx, menu_name) VALUES({timing_idx}, '{menu_name}');";
            try//예외 처리
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                if (command.ExecuteNonQuery() == 1)
                {
                    Console.WriteLine("인서트 성공");
                }
                else
                {
                    Console.WriteLine("인서트 실패");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("실패");
                Console.WriteLine(ex.ToString());
            }
        }
        public static List<Meal> GetMeals(MySqlConnection connection, string dtime)
        {
            List<Meal> result = new List<Meal>();

            string query = $"select count(l.idx) as popular, t.idx as timing, l.menu_name from timing_list t, like_meal l where t.idx = l.timing_idx and l.created_at > str_to_date('{dtime}', '%Y%m%d') group by l.menu_name order by popular DESC;";
            try//예외 처리
            {
                connection.Open();

                //ExecuteReader를 이용하여 연결 모드로 데이터 가져오기
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader table = cmd.ExecuteReader();
                while (table.Read())
                {
                    result.Add(new Meal(int.Parse(table[0].ToString()), int.Parse(table[1].ToString()), table[2].ToString()));
                }
                table.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return result;
        }
    }
    class timing_list
    {
        public static void CreateTable(MySqlConnection connection)
        {
            string query =
                "create table timing_list(" +
                "idx int auto_increment primary key," +
                "value char(50) not null" +
                ");";

            try//예외 처리
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                Console.WriteLine(command.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void Insert(string value, MySqlConnection connection)
        {
            string query = $"INSERT INTO timing_list(value) VALUES('{value}');";
            try//예외 처리
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                if (command.ExecuteNonQuery() == 1)
                {
                    Console.WriteLine("인서트 성공");
                }
                else
                {
                    Console.WriteLine("인서트 실패");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("실패");
                Console.WriteLine(ex.ToString());
            }
        }
    }
}