using System;
using System.Globalization;

namespace Practice8_1_1 {
    //Practice8-1-1 現在の日時を以下のような3種類の書式でコンソールに出力してください。
    /* ↓表示書式
    2019/1/15 19:48
    2019年01月15日 19時48分32秒
    平成31年 1月15日(火曜日)
    */
    class Program {
        static void Main(string[] args) {
            var wDate = new DateTime(2019, 1, 15, 19, 48, 32);

            Console.WriteLine(wDate.ToString("yyyy/M/d H:mm"));

            Console.WriteLine(wDate.ToString("yyyy年MM月dd日 HH時mm分ss秒"));

            var wCulture = new CultureInfo("ja-JP");
            var wJapanDay = wDate.ToString("ggyy年M月d日", wCulture);

            wCulture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var wDayOfWeek = wCulture.DateTimeFormat.GetDayName(wDate.DayOfWeek);

            Console.WriteLine($"{wJapanDay}({wDayOfWeek})");
        }
    }
}
