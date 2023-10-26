using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice3_1_3 {
    class Program {
        //LINQのWhereメソッドを使い、値が50以上の要素を列挙し、その結果をコンソールに出力してください。
        static void Main(string[] args) {
            var wNumbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };
            foreach (int wResult in wNumbers.Where(s => s >= 50)) {
                Console.WriteLine(wResult);
            }
        }
    }
}
