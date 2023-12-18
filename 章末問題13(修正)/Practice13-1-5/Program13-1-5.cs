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
        /// 書籍を挿入するメソッド
        /// </summary>
        static void InsertBooks() {
            using (var wDb = new BooksDbContext()) {
                var wBook1 = new Book {
                    Title = "坊ちゃん", PublishedYear = 2003, Author = new Author {
                        Birthday = new DateTime(1867, 2, 9), Gender = "M", Name = "夏目漱石", }
                };
                wDb.Books.Add(wBook1);
                var wBook2 = new Book {
                    Title = "人間失格 ", PublishedYear = 1990, Author = new Author {
                        Birthday = new DateTime(1909, 6, 19), Gender = "M", Name = "太宰治",
                    }
                };
                wDb.Books.Add(wBook2);
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
                    new Author { Birthday = new DateTime(1878, 12, 7), Gender = "F", Name = "与謝野晶子" },
                    new Author { Birthday = new DateTime(1896, 8, 27), Gender = "M", Name = "宮沢賢治" },
                    new Author { Birthday = new DateTime(1888, 12, 26), Gender = "M", Name = "菊池寛" },
                    new Author { Birthday = new DateTime(1899, 6, 14), Gender = "M", Name = "川端康成" }
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
                    new Book { Title = "みだれ髪", PublishedYear = 2000, Author = wAuthors.FirstOrDefault(x => x.Name == "与謝野晶子") },
                    new Book { Title = "銀河鉄道の夜", PublishedYear = 1989, Author = wAuthors.FirstOrDefault(x => x.Name == "宮沢賢治") },
                    new Book { Title = "真珠婦人", PublishedYear = 2002, Author = wAuthors.FirstOrDefault(x => x.Name == "菊池寛") },
                    new Book { Title = "伊豆の踊子", PublishedYear = 2003, Author = wAuthors.FirstOrDefault(x => x.Name == "川端康成") },
                    new Book { Title = "注文の多い料理店", PublishedYear = 2000, Author = wAuthors.FirstOrDefault(x => x.Name == "宮沢賢治") },
                    new Book { Title = "こころ", PublishedYear = 1991, Author = wAuthors.FirstOrDefault(x => x.Name == "夏目漱石") }
                };
                wDb.Books.AddRange(wBooksToAdd);
                wDb.SaveChanges();
            }
        }

        /// <summary>
        /// 最もタイトルの長い書籍を取得するメソッド
        /// </summary>
        /// <param name="vContext"></param>
        /// <returns>最もタイトルの長い書籍</returns>
        static IEnumerable<Book> DisplayBooksWithLongestTitle(BooksDbContext vContext) {
            var wMaxLength = vContext.Books.Max(x => x.Title.Length);
            return vContext.Books.Where(x => x.Title.Length == wMaxLength).ToList();
        }

        /// <summary>
        /// 発行年の古い順に指定した数の書籍を取得するメソッド
        /// </summary>
        static IEnumerable<Book> GetOldestThreeBooks(BooksDbContext vContext) {
            return vContext.Books.OrderBy(x => x.PublishedYear).Take(3).ToList();
        }

        /// <summary>
        /// 著者ごとに書籍のタイトルと発行年を取得するメソッド
        /// </summary>
        static IEnumerable<IGrouping<Author, Book>> GetBooksByAuthor(BooksDbContext vContext) {
            return vContext.Books.Include("Author").ToList().GroupBy(x => x.Author).OrderByDescending(group => group.Key.Birthday);
        }
    }
}

