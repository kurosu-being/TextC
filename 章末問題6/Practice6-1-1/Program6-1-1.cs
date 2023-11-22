using System;
using System.Linq;

namespace Practice6_1_1 {
    /* 次のような配列が定義されています。
         var  numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35, }
       この配列に対して以下のコードを書いて下さい。 */
    //Practice6-1-1 最大値を求め、結果を表示して下さい。
    class Program {
        static void Main(string[] args) {
            //ビーイングコーディング規約に合わせ問題分のnumbers→wNumbersに変更
            var wNumbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35, };

            //追加問題　要素があるかどうかを判定する処理を追加
            if (wNumbers.Any()) {
                Console.WriteLine(wNumbers.Max());
            } else {
                Console.WriteLine("要素がありません");
            }
        }
    }
}
