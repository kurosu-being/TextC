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


            var wCharCount = wInputString.ToUpper().Where(char.IsLetter).GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

            foreach ((char wChar, int wCount) in wCharCount.OrderBy(x => x.Key)) {
                Console.WriteLine($"'{wChar}':{wCount}");
            }
        }
    }
}
