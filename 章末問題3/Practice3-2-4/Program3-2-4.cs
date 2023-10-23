using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice3_2_4 {
    class Program {
        //LINQのWhereメソッドとSelectメソッドを使い、'B'で始まる都市名の文字数抽出し、その文字数をコンソールに出力してください。都市名を表示する必要はありません。
        static void Main(string[] args) {
            var wNames = new List<string> { "Tokyo", "ONew Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong" };
            var wWhere = wNames.Where(s => s[0] == 'B');
            var wNum = wWhere.Select(s => s.Length);
            foreach (var wN in wNum) {
                Console.WriteLine(wN);
            }
        }
    }
}

