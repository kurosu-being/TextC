using System;

namespace Practice4_2_4 {
    class Program {
        //Practice4-2-4 Practice4-2-3で作成したメソッドを呼び出し、最初に見つかった21世紀のデータの年を表示してください。見つからなければ、21世紀のデータはありませんと表示してください。
        static void Main(string[] args) {
            var wDay1 = new YearMonth(2000, 3);
            var wDay2 = new YearMonth(2005, 12);
            var wDay3 = new YearMonth(2004, 2);
            var wDay4 = new YearMonth(2030, 10);
            var wDay5 = new YearMonth(2450, 7);
            var wYearMonths = new YearMonth[] { wDay1, wDay2, wDay3, wDay4, wDay5, };
            var wFirst21YearMonth = FindFirst21YearMonth(wYearMonths);
            Console.WriteLine($"最初に見つかった21世紀の年: {(wFirst21YearMonth != null ? wFirst21YearMonth.Year.ToString() + "年" : "見つかりませんでした")}");
        }

        public static YearMonth FindFirst21YearMonth(YearMonth[] wYearMonths) {
            foreach (YearMonth wYearMonth in wYearMonths) {
                if (wYearMonth.Is21stCentury) {
                    return wYearMonth;
                }
            }
            return null;
        }
    }
}
