using System;

namespace Practice8_2_1 {
    //Practice8-2-1　p215「8.5.1:次の指定曜日を求める」のメソッドを参考に、次の週の指定曜日を求めるメソッドを定義してください。
    class Program {
        static void Main(string[] args) {
            var wToday = DateTime.Today;
            DateTime wNextWeekFriday = NextWeek(wToday, DayOfWeek.Sunday);
            Console.WriteLine(wNextWeekFriday);
        }
        /// <summary>
        /// 次の週の指定曜日を求めるメソッド
        /// </summary>
        /// <param name="vDate">日付</param>
        /// <param name="vDayOfWeek">指定曜日</param>
        /// <returns></returns>
        public static DateTime NextWeek(DateTime vDate, DayOfWeek vDayOfWeek) {
            int wDaysSpan = ((int)vDayOfWeek - (int)vDate.DayOfWeek + 7) % 7;
            return vDate.AddDays(wDaysSpan + 7);
        }
    }
}
