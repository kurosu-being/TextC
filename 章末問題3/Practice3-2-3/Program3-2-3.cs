using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice3_2_3 {
    class Program {
        //LINQのWhereメソッドを使い、小文字の'o'が含まれている都市名を抽出し、配列に格納してください。その後、配列の各要素をコンソールに出力してください。
        static void Main(string[] args) {
            var wCityNames = new List<string> { "Tokyo", "ONew Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong" };
            foreach (string wCityName in wCityNames.Where(s => s.Contains("o")).ToArray()) {
                Console.WriteLine(wCityName);
            }
        }
    }
}
