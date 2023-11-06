﻿namespace Practice6_2_6 {
    public class Book {
        /// <summary>
        /// タイトル
        /// </summary>
        public string Title { get; }
        /// <summary>
        /// 価格
        /// </summary>
        public int Price { get; }
        /// <summary>
        /// ページ数
        /// </summary>
        public int Pages { get; }
        /// <summary>
        /// Bookのコンストラクタ
        /// </summary>
        /// <param name="vTitle">タイトル</param>
        /// <param name="vPrice">価格</param>
        /// <param name="vPages">ページ数</param>
        public Book(string vTitle, int vPrice, int vPages) {
            this.Title = vTitle;
            this.Price = vPrice;
            this.Pages = vPages;
        }
    }
}

