using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice6_2_6 {
    //Practice6-2-5 booksの中で、ページ数が400ページ以上の書籍を、価格が高い順に表示（タイトルと価格を表示）するコードを書いてください。
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
            var wTopThreePrice = wBooks.Where(x => x.Pages >= 400).OrderByDescending(x => x.Price);
            Console.WriteLine("ページ数が400ページ以上の書籍を、価格が高い順に表示");
            foreach (var wBook in wTopThreePrice) {
                Console.WriteLine($"書籍: {wBook.Title} 価格:{wBook.Price.ToString("#,0")}円");
            }

        }
    }
}
