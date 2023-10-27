using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3_2_4_追加問題 {
    class Program {
        //追加問題　'n' で終わる都市名を抽出し、アルファベット順にならべたものを出力してください。
        static void Main(string[] args) {
            var wCityNames = new List<string> { "Tokyo", "ONew Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong", "" };
            var wMatchNames = wCityNames.Where(s => s.LastOrDefault() == 'n').OrderBy(x => x[0]);
            foreach (string wMatchName in wMatchNames) {
                Console.WriteLine(wMatchName);
            }
        }
    }
}
