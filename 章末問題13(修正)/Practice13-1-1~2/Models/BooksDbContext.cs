namespace Practice13_1_1_2.Models {
    using System.Data.Entity;

    /// <summary>
    /// DbContextクラス
    /// </summary>
    public class BooksDbContext : DbContext {
        /// <summary>
        /// 書籍と著者のデータベースコンテキスト
        /// </summary>
        public BooksDbContext()
            : base("name=BooksDbContext") {
        }
        /// <summary>
        /// Books テーブルへの DbSet
        /// </summary>
        public DbSet<Book> Books { get; set; }
        /// <summary>
        /// Author テーブルへの DbSet
        /// </summary>
        public DbSet<Author> Authors { get; set; }
    }
}