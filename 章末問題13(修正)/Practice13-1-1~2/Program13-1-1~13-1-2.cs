using Practice13_1_1_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice13_1_1_2 {
    //Practice13-1-1 本文で利用したデータベースを利用し、2名の著者と四冊の書籍を追加してください。
    //Practice13-1-2 すべての書籍情報を著者名とともに表示するコードを書き、Practice13-1-1のデータが正しく追加されたか確認してください。
    class Program {
        static void Main(string[] args) {
            // 著者を追加
            List<Author> wAuthorsToAdd = new List<Author> {
            new Author(1, "与謝野晶子", new DateTime(1878, 12, 7), "F", new List<Book>()),
            new Author(2, "宮沢賢治", new DateTime(1896, 8, 27), "M", new List<Book>()),
            new Author(3, "菊池寛", new DateTime(1888, 12, 26), "M", new List<Book>()),
            new Author(4, "川端康成", new DateTime(1899, 6, 14), "M", new List<Book>())
        };
            AddAuthors(wAuthorsToAdd);

            // 書籍を追加
            List<Book> wBooksToAdd = new List<Book> {
            new Book(1, "みだれ髪", 2000, wAuthorsToAdd[0]),
            new Book(2, "銀河鉄道の夜", 1989, wAuthorsToAdd[1]),
            new Book(3, "真珠婦人", 2002, wAuthorsToAdd[2]),
            new Book(4, "伊豆の踊子", 2003, wAuthorsToAdd[3]),
            new Book(5, "注文の多い料理店", 2000, wAuthorsToAdd[1]),
            new Book(6, "こころ", 1991, new Author(5, "夏目漱石", DateTime.Now, "M", null))
        };
            AddBooks(wBooksToAdd);

            DisplayAllBooks();
        }

        /// <summary>
        /// 書籍を挿入するメソッド（本文で作成したメソッド）
        /// </summary>
        static void InsertBooks() {
            using (var wDb = new BooksDbContext()) {
                var wBook1 = new Book(1, "坊ちゃん", 2003, new Author(5, "夏目漱石", new DateTime(1867, 2, 9), "M", new List<Book>()));
                wDb.Books.Add(wBook1);

                var wBook2 = new Book(2, "人間失格", 1990, new Author(6, "太宰治", new DateTime(1909, 6, 19), "M", new List<Book>()));
                wDb.Books.Add(wBook2);

                wDb.SaveChanges();
            }
        }


        /// <summary>
        /// 書籍を取得しコレクション化して返すメソッド（本文で作成したメソッド）
        /// </summary>
        /// <returns>書籍のコレクション</returns>
        static IEnumerable<Book> GetBooks() {
            using (var wDb = new BooksDbContext()) {
                return wDb.Books.ToList();
            }
        }

        /// <summary>
        /// 全ての書籍を表示するメソッド（本文で作成したメソッド）
        /// </summary>
        static void DisplayAllBooks() {
            foreach (var wBook in GetBooks()) {
                Console.WriteLine($"{wBook.Title}{wBook.PublishedYear}");
            }
            Console.ReadLine();
        }

        /// <summary>
        /// 著者を追加するメソッド
        /// </summary>
        private static void AddAuthors(List<Author> authorsToAdd) {
            using (var wDb = new BooksDbContext()) {
                wDb.Authors.AddRange(authorsToAdd);
                wDb.SaveChanges();
            }
        }

        /// <summary>
        /// 書籍を追加するメソッド
        /// </summary>
        private static void AddBooks(List<Book> booksToAdd) {
            using (var wDb = new BooksDbContext()) {
                wDb.Books.AddRange(booksToAdd);
                wDb.SaveChanges();
            }
        }
    }
}

