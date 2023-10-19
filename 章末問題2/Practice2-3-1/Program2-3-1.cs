using System;

namespace Practice2_3_1 {
    class Program {
        static void Main(string[] args) {
            var wSales = new CountSales("sales.csv");
            var wAmountPerItem = wSales.GetPerItemSales();
            foreach (var obj in wAmountPerItem) {
                Console.WriteLine($"{obj.Key}は合計{obj.Value}円です");
            }
        }
    }
}
