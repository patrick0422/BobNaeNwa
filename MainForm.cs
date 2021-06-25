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
    public partial class BobNaeNwa : Form
    {
        DateTime date = DateTime.Now;

        public BobNaeNwa()
        {
            InitializeComponent();

            UpdateMeal();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            date = date.AddDays(-1);
            UpdateMeal();
        }
        private void buttonDate_Click(object sender, EventArgs e)
        {
            date = DateTime.Now;
            UpdateMeal();
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            date = date.AddDays(1);
            UpdateMeal();
        }
        
        private void UpdateMeal()
        {
            string[] mealList = ParseMeal.GetMeal(date.ToString("yyyyMMdd"));

            buttonDate.Text = date.ToString("yyyy년 MM월 dd일 ") + $"{GetDay(date)}요일";

            labelBreakfast.Text = mealList[0];
            labelLunch.Text = mealList[1];
            labelDinner.Text = mealList[2];
        }



        private string GetDay(DateTime dt)
        {
            string strDay = "";

            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    strDay = "월";
                    break;
                case DayOfWeek.Tuesday:
                    strDay = "화";
                    break;
                case DayOfWeek.Wednesday:
                    strDay = "수";
                    break;
                case DayOfWeek.Thursday:
                    strDay = "목";
                    break;
                case DayOfWeek.Friday:
                    strDay = "금";
                    break;
                case DayOfWeek.Saturday:
                    strDay = "토";
                    break;
                case DayOfWeek.Sunday:
                    strDay = "일";
                    break;
            }

            return strDay;
        }


    }
}
