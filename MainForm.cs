using MySql.Data.MySqlClient;
using System;
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

        int timing_list_idx;
        string menu_name;

        public BobNaeNwa()
        {
            InitializeComponent();
            InitializeDatabase();
            UpdateMeal();
        }

        // DB 초기화
        private void InitializeDatabase()
        {
            using (MySqlConnection connection = like_meal.getConnection())
            {
                connection.Open();

                timing_list.CreateTable(connection);
                like_meal.CreateTable(connection);

                timing_list.Insert("breakfast", connection);
                timing_list.Insert("lunch", connection);
                timing_list.Insert("dinner", connection);
            }
        }

        // 이전날 급식 요청하는 함수
        private void buttonPrev_Click(object sender, EventArgs e)
        {
            date = date.AddDays(-1);
            UpdateMeal();
        }
        // 오늘 급식 요청하는 함수
        private void buttonDate_Click(object sender, EventArgs e)
        {
            if (date != DateTime.Now)
            {
                date = DateTime.Now;
                UpdateMeal();
            }
        }
        // 다음날 급식 요청하는 함수
        private void buttonNext_Click(object sender, EventArgs e)
        {
            date = date.AddDays(1);
            UpdateMeal();
        }
        
        // 급식 뿌리는 함수
        private void UpdateMeal()
        {
            // 리스트 클리어
            breakfastList.Items.Clear();
            lunchList.Items.Clear();
            dinnerList.Items.Clear();

            // 날짜 세팅
            buttonDate.Text = date.ToString("yyyy년 MM월 dd일 ") + $"{GetDay(date)}요일";

            // 급식 요청
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

        // 몇요일인지 구하는 함수
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

        // 급식을 더블 클릭했을 때 이벤트
        /*
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

                textBox1.Text = selectedItem;
            }
        }
        */

        // 좋아요 버튼
        private void buttonLike_Click(object sender, EventArgs e)
        {
            string selectedMeal = textBox1.Text.Trim();

            // 아무 메뉴도 선택하지 않았을 때는 무시
            if (selectedMeal == "")
                return;

            string[] aboutMeal = selectedMeal.Split("의 ".ToCharArray());

            using(MySqlConnection connection = like_meal.getConnection())
            {
                connection.Open();
                like_meal.Insert(timing_list_idx.ToString(), menu_name, connection);
            }
            
            
            MessageBox.Show($"{aboutMeal[2]}가 맛있었던 급식 목록에 추가되었습니다.", "맛있다!");
        }


        private int getTimingIdxFromTimingValue(string timingValue)
        {
            return timingValue == "조식" ? 1 : timingValue == "중식" ? 2 : timingValue == "석식" ? 3 : 0;
        }
        private string getMealTimingFromListName(string listName)
        {
            return listName == "breakfastList" ? "조식" : listName == "lunchList" ? "중식" : listName == "dinnerList" ? "석식" : "None";
        }

        // 메뉴 선택시 이벤트
        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox list = sender as ListBox;

            textBox1.Text = $"{getMealTimingFromListName(list.Name)}의 {list.SelectedItem.ToString()}";

            timing_list_idx = getTimingIdxFromTimingValue(getMealTimingFromListName(list.Name));
            menu_name = list.SelectedItem.ToString();
        }

        // 맛있었던 급식 버튼
        private void buttonRank_Click(object sender, EventArgs e)
        {
            new RankingForm().ShowDialog();
        }

        public static void ShowMsg(string msg)
        {
            MessageBox.Show(msg);
        }
    }
}
