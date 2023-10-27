namespace Practice2_3_1 {
    /// <summary>
    /// 売上情報のクラス
    /// </summary>
    class Sale {
        /// <summary>
        /// 店舗名
        /// </summary>
        public string ShopName { get; set; }
        /// <summary>
        /// 商品カテゴリ
        /// </summary>
        public string ProductCategory { get; set; }
        /// <summary>
        /// 売上高
        /// </summary>
        public int Amount { get; set; }
        /// <summary>
        /// Saleのコンストラクタ
        /// </summary>
        /// <param name="vShopName">店舗名</param>
        /// <param name="vProductCategory">商品カテゴリ</param>
        /// <param name="vAmount">売上高</param>
        public Sale(string vShopName, string vProductCategory, int vAmount) {
            this.ShopName = vShopName;
            this.ProductCategory = vProductCategory;
            this.Amount = vAmount;
        }
    }
}
