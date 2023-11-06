using System;
using System.Linq;

namespace Practice6_1_4 {
    //Practice6-1-4 数の小さい順に並べ、先頭から3つを取り出し、結果を表示して下さい。
    class Program {
        static void Main(string[] args) {
            var wNumbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            Console.WriteLine("小さい順に並べた最初の3つの要素:");
            foreach (int wSortNumber in wNumbers.OrderBy(x => x).Take(3)) {
                Console.WriteLine(wSortNumber);
            }
        }
    }
}
