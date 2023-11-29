using System;

namespace Practice8_2_1 {
    //Practice8-2-1　p215「8.5.1:次の指定曜日を求める」のメソッドを参考に、次の週の指定曜日を求めるメソッドを定義してください。
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("次の週の指定曜日を求めます。対応表に従って、0～6の数字を半角で入力してください。\n月曜日:1\n火曜日=2\n水曜日=3\n木曜日=4\n金曜日=5\n土曜日=6\n日曜日=0");
            var wInput = Console.ReadLine();
            if (!int.TryParse(wInput, out var wIntWeek) || wIntWeek < 0 || wIntWeek > 6) {
                Console.WriteLine("入力が適切ではありません。半角で0～6の数字を入力してください");
                return;
            }
            var wToday = DateTime.Today;
            DateTime wNextWeekDay = GetNextWeek(wToday, wIntWeek);

            Console.WriteLine($"次の週の指定曜日の日にちは{wNextWeekDay.ToString("D")}です");
        }

        /// <summary>
        /// 次の週の指定曜日を求めるメソッド
        /// </summary>
        /// <param name="vDate">日付</param>
        /// <param name="vDayOfWeek">指定曜日</param>
        /// <returns></returns>
        public static DateTime GetNextWeek(DateTime vDate, int vDayOfWeek) {
            int wDaysSpan = (vDayOfWeek - (int)vDate.DayOfWeek + 7);
            return vDate.AddDays(wDaysSpan);
        }
    }
}
