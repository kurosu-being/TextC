using System;

namespace Practice4_2_2 {
    class Program {
        //Practice4-2-2 この配列の要素(YearMonthオブジェクト)をすべて列挙し、その値をコンソールに出力してください。
        static void Main(string[] args) {
            var wYearMonths = new YearMonth[] {
                new YearMonth(2000, 3),
                new YearMonth(2010, 12),
                new YearMonth(2005, 2),
                new YearMonth(2023, 10),
                new YearMonth(2045, 7)
            };
            foreach (YearMonth wYearMonth in wYearMonths) {
                Console.WriteLine(wYearMonth);
            }
        }
    }
}
