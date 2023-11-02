namespace Practice4_2_3 {
    class Program {
        //Practice4-2-3 配列の中の最初に見つかった21世紀のYearMonthオブジェクトを返すメソッドを書いてください。見つからなかった場合は、nullを返してください。foreach文を使って実装してください。
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
