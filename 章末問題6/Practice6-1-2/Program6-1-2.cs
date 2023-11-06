using System;
using System.Linq;

namespace Practice6_1_2 {
    //Practice6-1-2 最後から2つの要素を取り出して表示してください。
    class Program {
        static void Main(string[] args) {
            var wNumbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };
            if(wNumbers.Length >= 2) {
                var wLastTwoElements = wNumbers.Skip(wNumbers.Length - 2);
                Console.WriteLine("最後から2つの要素:");
                foreach (int wElement in wLastTwoElements) {
                    Console.WriteLine(wElement);
                }
            }
            else{
                Console.WriteLine("コレクション数が1以下です");
            }   
        }
    }
}

