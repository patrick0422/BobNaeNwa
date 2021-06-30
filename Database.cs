using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobNaeNwa
{
    // MySqlConnection connection = new MySqlConnection($"Server=localhost;Port=3306;Database=bobnaenwa;Uid=root;Pwd=1234");
    class like_meal
    {
        public static void CreateTable(MySqlConnection connection)
        {
            string query =
                "create table like_meal(" +
                "idx int auto_increment primary key," +
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

        public static void Insert(string timing_list_idx, string menu_name, MySqlConnection connection)
        {
            string query = $"INSERT INTO  VALUES({timing_list_idx}, '{menu_name}');";
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
    }
}
