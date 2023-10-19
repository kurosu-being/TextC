using System;

namespace Practice2_3_1 {
    class Program {
        //「2.2:売上集計プログラム」で作成したプログラムを変更し、商品カテゴリ別の売上高を求めるプログラムを作成してください
        static void Main(string[] args) {
            var wSales = new CountSales("sales.csv");
            var wAmountPerItem = wSales.GetPerItemSales();
            foreach (var obj in wAmountPerItem) {
                Console.WriteLine($"{obj.Key}は合計{obj.Value}円です");
            }
        }
    }
}
