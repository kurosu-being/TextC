namespace Practice6_2_6 {
    public class Book {
        /// <summary>
        /// タイトル
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 価格
        /// </summary>
        public int Price { get; set; }
        /// <summary>
        /// ページ数
        /// </summary>
        public int Pages { get; set; }
        /// <summary>
        /// Bookのコンストラクタ
        /// </summary>
        /// <param name="vTitle"></param>
        /// <param name="vPrice"></param>
        /// <param name="vPages"></param>
        public Book(string vTitle, int vPrice, int vPages) {
            this.Title = vTitle;
            this.Price = vPrice;
            this.Pages = vPages;
        }
    }
}

