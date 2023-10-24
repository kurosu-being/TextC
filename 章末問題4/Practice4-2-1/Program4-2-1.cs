namespace Practice4_2_1 {
    class Program {
        //Practice4-1で定義したYearMonthクラスを使って、次のコードを書いてください。また、本章で学習したイディオムが使えるところでは、イディオムを使ってください。
        //Practice4-2-1 YearMonthを要素に持つ配列を定義し、初期値として5つのYearMonthオブジェクトをセットしてください。
        static void Main(string[] args) {
            var wDay1 = new YearMonth(2000, 3);
            var wDay2 = new YearMonth(2010, 12);
            var wDay3 = new YearMonth(2005, 2);
            var wDay4 = new YearMonth(2023, 10);
            var wDay5 = new YearMonth(2045, 7);
            var wLangs = new YearMonth[] { wDay1, wDay2, wDay3, wDay4, wDay5, };
        }
    }
}
