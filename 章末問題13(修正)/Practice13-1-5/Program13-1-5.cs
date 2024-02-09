using System;
using System.Collections.Generic;
using System.Linq;
using Practice13_1_1_2.Models;

namespace Practice13_1_5 {
    //Practice13-1-5 著者ごとに書籍のタイトルと発行歳を表示してください。なお、著者は誕生日の遅い順に並べ替えてください。
    class Program {
        static void Main(string[] args) {
            using (var wContext = new BooksDbContext()) {
                var wBooksByAuthor = GetBooksByAuthor(wContext);

                foreach (var wAuthorGroup in wBooksByAuthor) {
                    Console.WriteLine($"著者名: {wAuthorGroup.Key.Name}, 誕生日: {wAuthorGroup.Key.Birthday:D}");
                    foreach (var wBook in wAuthorGroup.OrderByDescending(x => x.PublishedYear)) {
                        Console.WriteLine($"書籍タイトル: {wBook.Title}, 発行年: {wBook.PublishedYear}年");
                    }
                }
            }
        }

        /// <summary>
        /// 書籍を挿入するメソッド（本文で作成したメソッド）
        /// </summary>
        static void InsertBooks(BooksDbContext dbContext, List<Book> booksToAdd) {
            using (var wDb = dbContext ?? new BooksDbContext()) {
                wDb.Books.AddRange(booksToAdd);
                wDb.SaveChanges();
            }
        }

        /// <summary>
        /// 書籍を取得するメソッド
        /// </summary>
        /// <returns>書籍のコレクション</returns>
        static IEnumerable<Book> GetBooks() {
            using (var wDb = new BooksDbContext()) {
                return wDb.Books.ToList();
            }
        }

        /// <summary>
        /// 全ての書籍を表示するメソッド
        /// </summary>
        static void DisplayAllBooks() {
            var wBooks = GetBooks();
            foreach (var wBook in wBooks) {
                Console.WriteLine($"{wBook.Title}{wBook.PublishedYear}");
            }
            Console.ReadLine();
        }

        /// <summary>
        /// 著者を追加するメソッド
        /// </summary>
        private static void AddAuthors() {
            using (var wDb = new BooksDbContext()) {
                var wAuthorsToAdd = new List<Author> {
                    new Author(1, "与謝野晶子", new DateTime(1878, 12, 7), "F", new List<Book>()),
                    new Author(2, "宮沢賢治", new DateTime(1896, 8, 27), "M", new List<Book>()),
                    new Author(3, "菊池寛", new DateTime(1888, 12, 26), "M", new List<Book>()),
                    new Author(4, "川端康成", new DateTime(1899, 6, 14), "M", new List<Book>())
                };
                wDb.Authors.AddRange(wAuthorsToAdd);
                wDb.SaveChanges();
            }
        }

        /// <summary>
        /// 書籍を追加するメソッド
        /// </summary>
        private static void AddBooks() {
            using (var wDb = new BooksDbContext()) {
                var wAuthors = wDb.Authors.ToList();

                var wBooksToAdd = new List<Book> {
                    new Book(1, "みだれ髪", 2000, wAuthors.FirstOrDefault(x => x.Name == "与謝野晶子")),
                    new Book(2, "銀河鉄道の夜", 1989, wAuthors.FirstOrDefault(x => x.Name == "宮沢賢治")),
                    new Book(3, "真珠婦人", 2002, wAuthors.FirstOrDefault(x => x.Name == "菊池寛")),
                    new Book(4, "伊豆の踊子", 2003, wAuthors.FirstOrDefault(x => x.Name == "川端康成")),
                    new Book(5, "注文の多い料理店", 2000, wAuthors.FirstOrDefault(x => x.Name == "宮沢賢治")),
                    new Book(6, "こころ", 1991, wAuthors.FirstOrDefault(x => x.Name == "夏目漱石"))
                };
                wDb.Books.AddRange(wBooksToAdd);
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

        /// <summary>
        /// 著者ごとに書籍のタイトルと発行年を取得するメソッド
        /// </summary>
        static IEnumerable<IGrouping<Author, Book>> GetBooksByAuthor(BooksDbContext vContext) {
            var wBooksWithAuthor = vContext.Books
                                    .Include("Author")
                                    .Where(book => book.Author != null) 
                                    .ToList();

            if (wBooksWithAuthor.Count == 0) {
                Console.WriteLine("書籍が見つかりませんでした。");
                return Enumerable.Empty<IGrouping<Author, Book>>();
            }

            return wBooksWithAuthor
                           .GroupBy(x => x.Author)
                           .OrderByDescending(y => y.Key.Birthday);
        }
    }
}

