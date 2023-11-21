using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Practice6_2_1;





namespace Practice6_2_2 {
    //Practice6-2-2 booksの中で、タイトルに"C#"が含まれている書籍が何冊あるかカウントするコードを書いてください。
    //追加問題 "C#" が大文字小文字、全角半角にかかわらずカウントされるように修正してみてください。
    class Program {
        static void Main(string[] args) {
            var wBooks = new List<Book>{
                //確認の為C#の表記を大文字小文字半角全角を試しています
                new Book("C#プログラミングの常識", 3800, 378),
                new Book("ラムダ式とLINQの極意", 2500, 312),
                new Book("ワンダフル・c#ライフ", 2900, 385),
                new Book("一人で学ぶ並列処理プログラミング", 4800, 464),
                new Book("フレーズで覚えるｃ#入門", 5300, 604),
                new Book("私でも分かったASP.NET MVC", 3200, 453),
                new Book("楽しいＣ♯プログラミング教室", 2540, 348),
            };

            if (wBooks == null) {
                Console.WriteLine("コレクションの中身がnullです。");
                return;
            }

            string wPattern = @"[CＣ][#♯]";

            int wCount = wBooks.Count(book => Regex.IsMatch(book.Title, wPattern, RegexOptions.IgnoreCase));

            Console.WriteLine($"タイトルに\"C#\"が含まれる書籍の数: {wCount}冊");
        }
    }
}



