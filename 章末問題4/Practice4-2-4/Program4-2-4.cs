using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4_2_4 {
    class Program {
        //Practice4-2-3 配列の中の最初に見つかった21世紀のYearMonthオブジェクトを返すメソッドを書いてください。見つからなかった場合は、nullを返してください。foreach文を使って実装してください。
        static void Main(string[] args) {
            var wDay1 = new YearMonth(2000, 3);
            var wDay2 = new YearMonth(200, 12);
            var wDay3 = new YearMonth(200, 2);
            var wDay4 = new YearMonth(203, 10);
            var wDay5 = new YearMonth(245, 7);
            var wYearMonths = new YearMonth[] { wDay1, wDay2, wDay3, wDay4, wDay5, };
            var wFirst21YearMonth = FindFirst21YearMonth(wYearMonths);
            Console.WriteLine($"最初に見つかった21世紀の年月: {wFirst21YearMonth?.ToString() ?? "見つかりませんでした"}");
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
