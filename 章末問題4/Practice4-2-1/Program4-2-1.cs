namespace Practice4_2_1 {
    class Program {
        //問題4.1で定義したYearMonthクラスを使って、次のコードを書いて下さい。本章で学んだイディオムが使えるところでは、イディオムを使ってください。
        //Practice4-2-1 YearMonthを要素に持つ配列を定義し、初期値として5つのYearMonthオブジェクトをセットしてください。
        static void Main(string[] args) {
            var wYearMonths = new YearMonth[] {
                new YearMonth(2000, 3),
                new YearMonth(2010, 12),
                new YearMonth(2005, 2),
                new YearMonth(2023, 10),
                new YearMonth(2045, 7)
            };
        }
    }
}
