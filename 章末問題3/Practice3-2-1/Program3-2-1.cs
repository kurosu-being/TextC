using System;
using System.Collections.Generic;

namespace Practice3_2_1 {
    class Program {
        /*以下のリストが定義してあります
        var names = new List<string>{
        "Tokyo","New Delhi", "Bangkok", "London", "Paris", "Berlin","Canberra"."Hong Kong",
        };
        このリストに対して、ラムダ式を使い次のコードを書いてください。
        Practice3-2-1 コンソールから入力した都市名が何番目に格納されているかList<T>のFindINdexメソッドを使って調べ、その結果をコンソールに出力してください。見つからなかったら、-1を出力してください。なお、コンソールの入力にはConsole.ReadLineメソッドを利用してください。
        */
        static void Main(string[] args) {
            var wCityNames = new List<string> { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong" };
            string wInput = Console.ReadLine();
            var wIndex = wCityNames.FindIndex(s => s == wInput);
            string wMessage = (wIndex >= 0) ? $"インデックス番号は {wIndex}" : "-1";
            Console.WriteLine(wMessage);
        }
    }
}
