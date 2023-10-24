using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4_2_2 {
    class Program {
        //Practice4-2-2 この配列の要素(YearMonthオブジェクト)をすべて列挙し、その値をコンソールに出力してください。
        static void Main(string[] args) {
            var wDay1 = new YearMonth(2000, 3);
            var wDay2 = new YearMonth(2010, 12);
            var wDay3 = new YearMonth(2005, 2);
            var wDay4 = new YearMonth(2023, 10);
            var wDay5 = new YearMonth(2045, 7);
            var wYearMonths = new YearMonth[] {wDay1, wDay2, wDay3, wDay4, wDay5,};
            foreach(YearMonth wYearMonth in wYearMonths){
                Console.WriteLine(wYearMonth);
            }
        }
    }
}
