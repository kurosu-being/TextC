using System;
namespace Practice4_1_4 {
    class Program {
        //Practice4-1-4 ToStringメソッドをオーバーライドしてください。結果は"2017年8月"といった形式にしてください。
        static void Main(string[] args) {
            YearMonth wYearMonth = new YearMonth (2000, 3);
            Console.WriteLine(wYearMonth);
        }
    }
}
