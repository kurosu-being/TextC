using System;

namespace Practice4_2_4 {
    class Program {
        //Practice4-2-4 Practice4-2-3で作成したメソッドを呼び出し、最初に見つかった21世紀のデータの年を表示してください。見つからなければ、21世紀のデータはありませんと表示してください。
        static void Main(string[] args) {
            var wYearMonths = new YearMonth[] {
                new YearMonth(2000, 3),
                new YearMonth(2010, 12),
                new YearMonth(2005, 2),
                new YearMonth(2023, 10),
                new YearMonth(2045, 7)
            };
            var wFirst21YearMonth = YearMonth.First21YearMonth(wYearMonths);
            Console.WriteLine($"最初に見つかった21世紀の年: {(wFirst21YearMonth != null ? wFirst21YearMonth.Year.ToString() + "年" : "見つかりませんでした")}");
        }
    }
}
