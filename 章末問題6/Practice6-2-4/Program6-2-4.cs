using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice6_2_4 {
    //Practice6-2-4 booksの中で、価格が4000円以上の本で最初に見つかった書籍のタイトルを表示するコードを書いてください。
    class Program {
        static void Main(string[] args) {
            var wBooks = new List<Book>
            {
                new Book ("C#プログラミングの常識", 3800, 378 ),
                new Book ("ラムダ式とLINQの極意",2500, 312 ),
                new Book ( "ワンダフル・C#ライフ", 2900, 385 ),
                new Book ( "一人で学ぶ並列処理プログラミング", 4800, 464 ),
                new Book ( "フレーズで覚えるC#入門", 5300, 604 ),
                new Book ( "私でも分かったASP.NET MVC", 3200, 453 ),
                new Book ( "C#プログラミングの常識", 2540, 348 ),
            };

            string wTargetBookTitle = wBooks.FirstOrDefault(x => x.Price >= 4000) != null ? $"価格が4000円以上の本で最初に見つかった書籍のタイトル: {wBooks.FirstOrDefault(x => x.Price >= 4000).Title}" : "4000円以上の書籍はありません。";
            Console.WriteLine(wTargetBookTitle);
        }
    }
}
