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
        public RankingForm()
        {
            InitializeComponent();

            OnRangeChanged("주간");
        }

        private void buttonWeek_Click(object sender, EventArgs e)
        {
            OnRangeChanged("주간");
        }

        private void buttonMonth_Click(object sender, EventArgs e)
        {
            OnRangeChanged("월간");
        }

        private void buttonYear_Click(object sender, EventArgs e)
        {
            OnRangeChanged("연간");
        }

        private void OnRangeChanged(string range)
        {
            MySqlConnection connection = new MySqlConnection($"Server=localhost;Port=3306;Database=bobnaenwa;Uid=root;Pwd=12341234");
            DateTime dtime = DateTime.Now;

            listBox1.Items.Clear();

            switch (range.ToString())
            {
                case "주간":
                    dtime.AddDays(-7);
                    break;
                case "월간":
                    dtime.AddMonths(1);
                    break;
                case "연간":
                    dtime.AddYears(1);
                    break;
                default:
                    break;
            }

            Database.
        }
    }
}
