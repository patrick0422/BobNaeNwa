using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

class ParseMeal
{
    // API URL
    static string API_URL = "https://open.neis.go.kr/hub/mealServiceDietInfo";
    // 요청 인자들
    static string parameter = "?"
        + "Type=json"
        + "&KEY=bfa95730b1b84b07b2db733b2138d9aa"
        + "&pIndex=1"
        + "&pSize=100"
        + "&ATPT_OFCDC_SC_CODE=F10"
        + "&SD_SCHUL_CODE=7380292";

    public static string mealWebRequest(string date)
    {
        string result = string.Empty;

        try
        {
            string dataString = parameter + "&MLSV_YMD=" + date;
            byte[] dataByte = Encoding.UTF8.GetBytes(dataString);
            WebRequest request = WebRequest.Create(API_URL + dataString);
            request.Method = "GET";
            HttpWebResponse httpWebResponse;
            using (httpWebResponse = (HttpWebResponse)request.GetResponse())
            using (Stream dataStream = httpWebResponse.GetResponseStream())
            using (StreamReader reader = new StreamReader(dataStream, Encoding.GetEncoding("UTF-8")))
            {
                string json = reader.ReadToEnd();
                result = json;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }

        return result;
    }

    public static string[] GetMeal(string date)
    {
        // 처리 결과를 담을 변수
        string[] mealList = new string[3];

        // 응답 받아오기
        JObject root = JObject.Parse(mealWebRequest(date));


        // 응답 최상단에 RESULT가 실려 온 경우, 조회가 안된것이므로 정보가 없다는 내용을 실어 반환
        if (root.ContainsKey("RESULT"))
        {
            for (int i = 0; i < mealList.Length; i++)
                mealList[i] = "정보 없음";

            return mealList;
        }


        JToken token = root["mealServiceDietInfo"];

        JArray mealServiceDietInfo = (JArray)token;

        JToken row = mealServiceDietInfo[1]["row"];
        JArray rowArray = (JArray)row;


        for (int i = 0; i < rowArray.Count; i++)
        {
            string temp = Regex.Replace(rowArray[i]["DDISH_NM"].ToString(), @"[^가-힣<br\\>]", "");
            mealList[i] = Regex.Replace(temp, @"[^<br\\>]", "\n");
        }

        return mealList;
    }
    public static ArrayList[] GetMeals(string date)
    {
        // 처리 결과를 담을 변수
        ArrayList[] result = new ArrayList[3];
        JObject root = null;

        // 응답 받아오기
        try
        {
            root = JObject.Parse(mealWebRequest(date));
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }


        // 응답 최상단에 RESULT가 실려 온 경우, 조회가 안된것이므로 정보가 없다는 내용을 실어 반환
        if (root.ContainsKey("RESULT"))
        {
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new ArrayList();
                result[i].Add("정보 없음");
            }
            return result;
        }


        JToken token = root["mealServiceDietInfo"];

        JArray mealServiceDietInfo = (JArray)token;

        JToken row = mealServiceDietInfo[1]["row"];
        JArray rowArray = (JArray)row;
        Console.WriteLine($"rowCount = {rowArray.Count}");

        // 조식, 중식만 있을 때 석식에 수동으로 정보 없음 문구 추가
        if (rowArray.Count <= 2)
        {
            result[2] = new ArrayList();
            result[2].Add("정보 없음");
        }
        for (int i = 0; i < rowArray.Count; i++)
        {
            string temp = rowArray[i]["DDISH_NM"].ToString();

            string[] meals = temp.Split(new string[] { "<br/>" }, StringSplitOptions.None);

            ArrayList list = new ArrayList();
            foreach (string s in meals)
            {
                string meal = s;

                for (int j = 0; j <= 9; j++)
                    meal = meal.Split(j.ToString()[0])[0];
                meal = meal.Split('*')[0];

                list.Add(meal);
            }


            result[i] = list;
        }

        

        return result;
    }
}