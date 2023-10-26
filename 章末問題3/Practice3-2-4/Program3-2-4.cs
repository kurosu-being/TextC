using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice3_2_4 {
    class Program {
        //LINQのWhereメソッドとSelectメソッドを使い、'B'で始まる都市名の文字数抽出し、その文字数をコンソールに出力してください。都市名を表示する必要はありません。
        static void Main(string[] args) {
            var wCityNames = new List<string> { "Tokyo", "ONew Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong", "Edmonton" };
            //wCityNames.Where(s => s.FirstOrDefault() == 'B')?.Select(s => s.Length)の記述が長いと判断したため、変数を定義しました。
            var wFirstS = wCityNames.Where(s => s.FirstOrDefault() == 'B')?.Select(s => s.Length);
            foreach (int wMessage in wFirstS) {
                Console.WriteLine(wMessage);
            }
            var wLastN = wCityNames.Where(s => s.LastOrDefault() == 'n')?.OrderBy(x => x[0]);
            foreach (string wMessage2 in wLastN) {
                Console.WriteLine(wMessage2);
            }
        }
    }
}


