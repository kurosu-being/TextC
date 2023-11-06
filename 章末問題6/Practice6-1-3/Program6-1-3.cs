using System;
using System.Linq;

namespace Practice6_1_3 {
    //Practice6-1-3 それぞれの数値を文字列に変換し、結果を表示して下さい。
    class Program {
        static void Main(string[] args) {
            var wNumbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            foreach (string wStringNumber in wNumbers.Select(x => x.ToString()).ToArray()) {
                Console.WriteLine(wStringNumber);
            }
        }
    }
}
