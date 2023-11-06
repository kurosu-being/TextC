using System;
using System.Linq;

namespace Practice6_1_5 {
    //Practice6-1-5 重複を排除した後、10より大きい値がいくつあるのかカントし、結果を表示して下さい
    class Program {
        static void Main(string[] args) {
            var wNumbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            Console.WriteLine($"10より大きい値:{wNumbers.Distinct().Count(x => x > 10)}");
        }
    }
}
