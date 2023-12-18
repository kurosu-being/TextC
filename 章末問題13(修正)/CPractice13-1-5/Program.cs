using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPractice13_1_5 {
    class Program {
        static void Main(string[] args) {
            static void Main(string[] args) {
                AddAuthors();
                AddBooks();
                DisplayAllBooks();
            }

            /// <summary>
            /// 書籍を挿入するメソッド（本文で作成したメソッド）
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
        }
    }
