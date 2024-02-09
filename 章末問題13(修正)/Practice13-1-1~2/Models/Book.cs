namespace Practice13_1_1_2.Models {
    /// <summary>
    /// Bookクラス
    /// </summary>
    public class Book {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// タイトル
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 出版年
        /// </summary>
        public int PublishedYear { get; set; }
        /// <summary>
        /// 著者
        /// </summary>
        public virtual Author Author { get; set; }

        //コンストラクタ
        public Book(int vId, string vTitle, int vPublishYear, Author vAuthor) {
            this.Id = vId;
            this.Title = vTitle;
            this.PublishedYear = vPublishYear;
            this.Author = vAuthor;
        }
        //コンストラクタ
        public Book() { }
    }
}
