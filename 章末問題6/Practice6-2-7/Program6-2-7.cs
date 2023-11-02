using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice6_2_7 {
    //Practice6-2-7 booksの中で、タイトルに"C#"が含まれていてかつ500ページ以下の本を見つけ、本のタイトルを表示するコードを書いてください。複数見つかった場合は、その全てを表示してください。
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
            var wTopThreePrice = wBooks.Where(x => x.Title.Contains("C#") && x.Pages <= 500);
            Console.WriteLine("タイトルに「C#」が含まれていてかつ500ページ以下の本");
            foreach (var wBook in wTopThreePrice) {
                Console.WriteLine($"書籍: {wBook.Title}");
            }

        }
    }
}
