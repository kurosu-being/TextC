using System;
using System.Collections.Generic;
using System.Linq;


namespace Practice6_2_1 {
    /* 次のようなリストが定義されています。

         var books = new List<Book>{
         new Book { Title = "C#プログラミングの常識", Price = 3800, PageNumber = 378, },
         new Book { Title = "ラムダ式とLINQの極意", Price = 2500, PageNumber = 312, },
         new Book { Title = "ワンダフル・C#ライフ", Price = 2900, PageNumber = 385, },
         new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, PageNumber = 464, },
         new Book { Title = "フレーズで覚えるC#入門", Price = 5300, PageNumber = 604, },
         new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, PageNumber = 453, },
         new Book { Title = "C#プログラミングの常識", Price = 2540, PageNumber = 348, },
         };

       このbooksリストに対して、以下のコードを書いて下さい。*/

    //Practice6-2-1 booksの中で、タイトルが"ワンダフル・C#ライフ" である書籍の価格とページ数を表示するコードを書いて下さい。
    class Program {
        static void Main(string[] args) {
            //ビーイングコーディング規約に則りbooks→wBooksに変更
            //定義されたリストを、Bookクラスにコンストラクタを定義した形に変更
            var wBooks = new List<Book>
            {
                new Book("C#プログラミングの常識", 3800, 378),
                new Book("ラムダ式とLINQの極意", 2500, 312),
                new Book("ワンダフル・C#ライフ", 2900, 385),
                new Book("一人で学ぶ並列処理プログラミング", 4800, 464),
                new Book("フレーズで覚えるC#入門", 5300, 604),
                new Book("私でも分かったASP.NET MVC", 3200, 453),
                new Book("楽しいC#プログラミング教室", 2540, 348),
            };

            var wTargetBook = wBooks.FirstOrDefault(x => x.Title == "ワンダフル・C#ライフ");
            //価格はカンマ付き数字に変換しています
            string wBookInfomation = wTargetBook != null
                ? $"書籍「{wTargetBook.Title}」の価格は {wTargetBook.Price.ToString("#,0")}円でページ数は{wTargetBook.PageNumber}Pです" : "指定したタイトルの本が見つかりませんでした。";
            Console.WriteLine(wBookInfomation);
        }
    }
}
