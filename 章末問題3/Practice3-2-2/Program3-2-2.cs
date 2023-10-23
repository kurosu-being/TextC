using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice3_2_2 {
    class Program {
        //LINQのCountメソッドを使い、小文字の'o'が含まれている都市名がいくつあるかカウントし、その結果をコンソールに出力してください。
        static void Main(string[] args) {
            var wNames = new List<string> { "Tokyo", "ONew Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong" };
            var wCount = wNames.Count(s => s.Contains("o"));
            Console.WriteLine(wCount);
        }
    }
}
