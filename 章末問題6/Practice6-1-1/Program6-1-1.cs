using System;
using System.Linq;

namespace Practice6_1_1 {
    //Practice6-1-2 最後から2つの要素を取り出して表示させてください。
    class Program {
        static void Main(string[] args) {
            //ビーイングコーディング規約に合わせ問題分のnumbers→wNumbersに変更
            var wNumbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35, };
            var wMax = wNumbers.Max();
            Console.WriteLine(wMax);

        }
    }
}
