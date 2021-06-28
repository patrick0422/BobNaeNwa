﻿using System;
using System.Collections;
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
            if (date != DateTime.Now)
            {
                date = DateTime.Now;
                UpdateMeal();
            }
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            date = date.AddDays(1);
            UpdateMeal();
        }
        
        private void UpdateMeal()
        {
            breakfastList.Items.Clear();
            lunchList.Items.Clear();
            dinnerList.Items.Clear();

            buttonDate.Text = date.ToString("yyyy년 MM월 dd일 ") + $"{GetDay(date)}요일";

            /*
            string[] mealList = ParseMeal.GetMeal(date.ToString("yyyyMMdd"));
            labelBreakfast.Text = mealList[0];
            labelLunch.Text = mealList[1];
            labelDinner.Text = mealList[2];
            */

            ArrayList[] mealList = ParseMeal.GetMeals(date.ToString("yyyyMMdd"));

            foreach (string meal in mealList[0])
            {
                breakfastList.Items.Add(meal);
            }
            foreach (string meal in mealList[1])
            {
                lunchList.Items.Add(meal);
            }
            foreach (string meal in mealList[2])
            {
                dinnerList.Items.Add(meal);
            }
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

        private void OnMealDoubleClick(object sender, MouseEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            // 인덱스를 저장할 변수
            int selectedIndex = -1;
            // 마우스 포인터의 위치
            Point point = e.Location;
            // 리스트 박스의 IndexFromPoint 메서드 호출
            selectedIndex = listBox.IndexFromPoint(point);
            if (selectedIndex != -1) // 빈 공간이 아닌 곳을 더블클릭 했을 때.
            {
                // 선택된 항목 저장
                string selectedItem = listBox.Items[selectedIndex].ToString();

                MessageBox.Show($"{selectedItem}(이)가 저장되었습니다.", "저장 완료");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new RankingForm().ShowDialog();
        }
    }
}
