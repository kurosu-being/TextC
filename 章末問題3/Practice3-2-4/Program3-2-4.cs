using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice3_2_4 {
    class Program {
        //LINQのWhereメソッドとSelectメソッドを使い、'B'で始まる都市名の文字数抽出し、その文字数をコンソールに出力してください。都市名を表示する必要はありません。
        static void Main(string[] args) {
            var wCityNames = new List<string> { "Tokyo", "ONew Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong", "Edmonton", "LYon", "LYan", };
            foreach (int wCityLengthS in wCityNames.Where(s => s.FirstOrDefault() == 'B').Select(s => s.Length)) {
                Console.WriteLine(wCityLengthS);
            }

            //追加問題　同様に、'n' で終わる都市名を抽出し、アルファベット順にならべたものを出力してください。
            foreach (string wCityLengthN in wCityNames.Where(s => s.LastOrDefault() == 'n').OrderBy(x => x)) {
                Console.WriteLine(wCityLengthN);
            }
        }
    }
}


