using System;
using System.Linq;

namespace Practice4_2_5 {
    class Program {
        //Practice4-2-5 配列に格納されているすべてのYearMonthの1ヶ月後を求め、その結果を新たな配列に入れてください。その後、その配列の要素の内容（年月）を順に表示してください。LINQを使える所はLINQを使って実装してみてください。
        static void Main(string[] args) {
            var wDay1 = new YearMonth(2000, 3);
            var wDay2 = new YearMonth(2100, 12);
            var wDay3 = new YearMonth(2000, 2);
            var wDay4 = new YearMonth(2003, 10);
            var wDay5 = new YearMonth(2450, 7);
            var wYearMonths = new YearMonth[] { wDay1, wDay2, wDay3, wDay4, wDay5, };
            for (int i = 0; i < wYearMonths.Length; i++) {
                wYearMonths[i].AddOneMonth();
            }
            var wNextYearMonths = wYearMonths.OrderBy(x => new DateTime(x.Year, x.Month, 1)).ToArray();
            foreach (var wYearMonth in wNextYearMonths) {
                Console.WriteLine(wYearMonth.ToString());
            }
        }
    }
}
