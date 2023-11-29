using System;

namespace Practice8_2_1 {
    //Practice8-2-1　p215「8.5.1:次の指定曜日を求める」のメソッドを参考に、次の週の指定曜日を求めるメソッドを定義してください。
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("次の週の指定曜日を求めます。対応表に従って、数字を半角で入力してください。\n月曜日:1\n火曜日=2\n水曜日=3\n木曜日=4\n金曜日=5\n土曜日=6\n日曜日=0");
            var wDayWeek = Console.ReadLine();
            if (!int.TryParse(wDayWeek, out var wIntWeek)){
                Console.WriteLine("入力が適切ではありません。半角数字を入力してください");
                return;
            } 

            var wToday = DateTime.Today;
            DateTime wNextWeekDay = NextWeek(wToday, wIntWeek);

            Console.WriteLine(wNextWeekDay.ToString("yyyy/M/d"));

        }

        /// <summary>
        /// 次の週の指定曜日を求めるメソッド
        /// </summary>
        /// <param name="vDate">日付</param>
        /// <param name="vDayOfWeek">指定曜日</param>
        /// <returns></returns>
        public static DateTime NextWeek(DateTime vDate, int vDayOfWeek) {
            int wDaysSpan = ((int)vDayOfWeek - (int)vDate.DayOfWeek + 7);
            return vDate.AddDays(wDaysSpan);
        }
    }
}
