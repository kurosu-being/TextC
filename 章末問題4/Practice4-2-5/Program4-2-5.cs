using System;
using System.Linq;

namespace Practice4_2_5 {
    class Program {
        //Practice4-2-5 配列に格納されているすべてのYearMonthの1ヶ月後を求め、その結果を新たな配列に入れてください。その後、その配列の要素の内容（年月）を順に表示してください。LINQを使える所はLINQを使って実装してみてください。
        static void Main(string[] args) {
            var wYearMonths = new YearMonth[] {
                new YearMonth(2000, 3),
                new YearMonth(2010, 12),
                new YearMonth(2005, 2),
                new YearMonth(2023, 10),
                new YearMonth(2045, 7)
            };

            var wSortYearMonths = wYearMonths.Select(x => x.AddOneMonth()).OrderBy(x => x).ToArray();
            foreach (var wYearMonth in wSortYearMonths) {
                Console.WriteLine(wYearMonth.ToString());
            }
        }
    }
}
