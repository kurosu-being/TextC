using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3_2_4_追加問題 {
    class Program {
        //LINQのWhereメソッドとSelectメソッドを使い、'B'で始まる都市名の文字数抽出し、その文字数をコンソールに出力してください。都市名を表示する必要はありません。
        static void Main(string[] args) {
            var wCityNames = new List<string> { "Tokyo", "ONew Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong", "" };
            var wMatchNames = wCityNames.Where(s => s.LastOrDefault() == 'n').OrderBy(x => x[0]);
            foreach (string wMessage2 in wMatchNames) {
                Console.WriteLine(wMessage2);
            }
        }
    }
}
