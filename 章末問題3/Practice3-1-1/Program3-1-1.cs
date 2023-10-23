using System;
using System.Collections.Generic;

namespace Practice3_1_1 {
    class Program {
        static void Main(string[] args) {
            //右のリストが定義してあります。var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 }; このリストに対して、ラムダ式を使い、次のコードを書いてください。
            //Practice3-1-1 List<T>のExistsメソッドを使い、8か9で割り切れる数があるかどうかを調べ、その結果をコンソールに出力してください。
            //ビーイングのコーディング規約に則り、問題文のnumbersをwNumbersに変更
            var wNumbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };
            var wExsits = wNumbers.Exists(s => s % 9 == 0 || s % 8 == 0);
            Console.WriteLine(wExsits);
        }
    }
}
