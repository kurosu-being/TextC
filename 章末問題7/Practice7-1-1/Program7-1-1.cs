using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice7_1_1 {
    /* "Cozy lummox gives smart squid who asks for job pen" という文字列があります。
      　この文字列に対して、以下のコードを書いて下さい。*/
    /* Practice7-1-1 各アルファベット文字（空白などアルファベット以外は除外）が何文字ずつ表れるかカウントするプログラムを書いて下さい。
    このときに、必ずディクショナリクラスを使って下さい。大文字/小文字の区別はしないでください。以下の形式で出力して下さい。
    'A' : 2
    'B' : 1
    'C' : 1
    'D' : 1
    */
    class Program {
        static void Main(string[] args) {
            string wInputString = "Cozy lummox gives smart squid who asks for job pen";

            wInputString = wInputString.ToUpper();
            var wCharCount = new Dictionary<char, int>();

            foreach (char wCharacter in wInputString) {
                if (char.IsLetter(wCharacter)) {
                    wCharCount[wCharacter] = wCharCount.ContainsKey(wCharacter) ? wCharCount[wCharacter] + 1 : 1;
                }
            }

            foreach (var wKeyValuePair in wCharCount.OrderBy(x => x.Key)) {
                Console.WriteLine($"'{wKeyValuePair.Key}':{wKeyValuePair.Value}");
            }
        }
    }
}
