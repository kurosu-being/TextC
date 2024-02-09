using System;
using System.Collections.Generic;
using System.Linq;
using Practice13_1_1_2.Models;

namespace Practice13_1_4 {
    //Prqactice13-1-4 発行歳の古い順に3札だけ書籍を取得し、そのタイトルと著者名を求めてください。
    class Program {
        static void Main(string[] args) {
            using (var wDb = new BooksDbContext()) {
                var wOldestBooks = GetOldestThreeBooks(wDb.Books, 3);

                if (!wOldestBooks.Any()) {
                    Console.WriteLine("書籍が見つかりませんでした。");
                }

                foreach (var wBook in wOldestBooks) {
                    Console.WriteLine($"書籍タイトル: {wBook.Title} 著者名: {wBook.Author.Name}");
                }
            }
        }

        /// <summary>
        /// 書籍を挿入するメソッド（本文で作成したメソッド）
        /// </summary>
        static void InsertBooks(BooksDbContext vDbContext, List<Book> vBooksToAdd) {
            using (var wDb = vDbContext ?? new BooksDbContext()) {
                wDb.Books.AddRange(vBooksToAdd);
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
        /// 書籍を表示するメソッド
        /// </summary>
        /// <param name="vBooks">表示する書籍のコレクション</param>
        static void DisplayBooks(IEnumerable<Book> vBooks) {
            foreach (var wBook in vBooks) {
                Console.WriteLine($"{wBook.Title} ({wBook.PublishedYear}年)");
            }
            Console.ReadLine();
        }

        /// <summary>
        /// 著者を追加するメソッド
        /// </summary>
        private static void AddAuthors(List<Author> vAuthorsToAdd) {
            using (var wDb = new BooksDbContext()) {
                wDb.Authors.AddRange(vAuthorsToAdd);
                wDb.SaveChanges();
            }
        }

        /// <summary>
        /// 書籍を追加するメソッド
        /// </summary>
        private static void AddBooks(List<Book> vBooksToAdd) {
            using (var wDb = new BooksDbContext()) {
                wDb.Books.AddRange(vBooksToAdd);
                wDb.SaveChanges();
            }
        }

        /// <summary>
        /// 最もタイトルの長い書籍を取得するメソッド
        /// </summary>
        /// <param name="vBooks">書籍のコレクション</param>
        /// <returns>最もタイトルの長い書籍</returns>
        static IEnumerable<Book> EnumerateBooksLongestTitle(IEnumerable<Book> vBooks) {
            if (vBooks == null || !vBooks.Any()) {
                Console.WriteLine("コレクションが存在しません");
                return Enumerable.Empty<Book>();
            }

            var wMaxLength = vBooks.Max(x => x.Title.Length);
            return vBooks.Where(x => x.Title.Length == wMaxLength);
        }

        /// <summary>
        /// 発行年の古い順に指定した数の書籍を取得するメソッド
        /// </summary>
        static IEnumerable<Book> GetOldestThreeBooks(IEnumerable<Book> vBooks, int vCount) {
            return vBooks.OrderBy(x => x.PublishedYear).Take(vCount);
        }
    }
}
