namespace Practice13_1_1_2.Models {
    using System;
    using System.Data.Entity;
    using System.Linq;

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
        // モデルに含めるエンティティ型ごとに DbSet を追加します。Code First モデルの構成および使用の
        // 詳細については、http://go.microsoft.com/fwlink/?LinkId=390109 を参照してください。

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}