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
            listBox1.Items.Clear();
            MySqlController msCtr = new MySqlController();
            DateTime dtime = DateTime.Now;
            DataSet ds;
            switch (range.ToString())
	        {
                case "주간":
                    dtime.AddDays(-7);
                    break;
                case "월간":
                    dtime.AddMonths(-1);
                    break;
                case "연간":
                    dtime.AddYears(-1);
                    break;
		        default:
                    break;
	        }
            ds = msCtr.ExcuteSQL($"select t.value, l.menu_name from timing_list t, like_menu l where t.idx == l.timing_idx and created_at > {dtime.ToString()} order by asc;");
            listBox1.Items.Add(ds);
            // 여기에서 리스트 잘 업데이트
        }
    }
}
