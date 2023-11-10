using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice6_2_2 {
    //Practice6-2-2 booksの中で、タイトルに"C#"が含まれている書籍が何冊あるかカウントするコードを書いてください。
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
                new Book ( "楽しいC#プログラミング教室", 2540, 348 ),
            };

            if (wBooks == null) {
                Console.WriteLine("本が登録されていません。");
                return;
            }
            Console.WriteLine($"タイトルに\"C#\"が含まれる書籍の数: {wBooks.Count(x => x.Title.Contains("C#"))}冊");
        }
    }
}
