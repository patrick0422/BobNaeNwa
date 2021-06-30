using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BobNaeNwa
{
    public partial class RankingForm : Form
    {
        
        public enum RangeList { week, month, year}
        public RankingForm()
        {
            InitializeComponent();

            OnRangeChanged(RangeList.week);
        }

        private void buttonWeek_Click(object sender, EventArgs e)
        {
            OnRangeChanged(RangeList.week);
        }

        private void buttonMonth_Click(object sender, EventArgs e)
        {
            OnRangeChanged(RangeList.month);
        }

        private void buttonYear_Click(object sender, EventArgs e)
        {
            OnRangeChanged(RangeList.year);
        }

        private void OnRangeChanged(RangeList range)
        {

            DateTime dtime = DateTime.Now;
            listBox1.Items.Clear();
            switch (range)
            {
                case RangeList.week:
                    dtime = dtime.AddDays(-7);
                    break;
                case RangeList.month:
                    dtime = dtime.AddMonths(-1);
                    break;
                case RangeList.year:
                    dtime = dtime.AddYears(-1);
                    break;
                default:
                    dtime = dtime.AddDays(-7);
                    break;
            }
            List<Meal> data = new List<Meal>();
            using (MySqlConnection connection = like_meal.getConnection())
            {
                data = like_meal.GetMeals(connection, dtime.ToString("yyyyMMdd"));
            }
            string[] timing = { "태웅로켓", "조식", "중식", "석식" };
            //data.ToList().ForEach(column =>
            //{
            //    listBox1.Items.Add($"{timing[column.timing]} : {column.menu_name}가\n{column.popular}개의 추천을 받았습니다.");
            //});
            foreach(Meal column in data)
            {
                listBox1.Items.Add($"{timing[column.timing]} : {column.menu_name} ❤ {column.popular}");
            }

        }
    }
}
