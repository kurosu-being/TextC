using System;

namespace Practice2_3_1 {
    class Program {
        //「2.2:売上集計プログラム」で作成したプログラムを変更し、商品カテゴリ別の売上高を求めるプログラムを作成してください
        static void Main(string[] args) {
            Console.WriteLine("sales.csvのパスを入力してください(sales.csvファイルはチケットに貼っています)");
            string wInputText = Console.ReadLine();
            var wSales = new SalesCounter(wInputText);
            foreach (var wObj in wSales.GetPerItemSales()) {
                Console.WriteLine($"{wObj.Key}は合計{wObj.Value}円です");
            }
        }
    }
}
