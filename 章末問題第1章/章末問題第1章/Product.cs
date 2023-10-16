namespace Henkou {
    public class Product {
        /// <summary>
        /// 商品コード
        /// </summary>
        public int Code { get; private set; }
        /// <summary>
        /// <商品名>
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// <商品価格（税抜き）>
        /// </summary>
        public int Price { get; set; }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="code"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public Product(int code, string name, int price) {
            this.Code = code;
            this.Name = name;
            this.Price = price;
        }
        /// <summary>
        /// 消費税を求める（消費税率は10%）
        /// /// </summary>
        /// <returns>int</returns>
        public int GetTax() {
            return (int)(Price * 0.1);
        }
    }
}
