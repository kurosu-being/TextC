using System;

namespace Henkou {
    public class Product {
        /// <summary>
        /// 商品コード
        /// </summary>
        public int Code { get; }
        /// <summary>
        /// <商品名>
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// <商品価格（税抜き）>
        /// </summary>
        public int Price { get; set; }
        /// <summary>
        /// Productクラスのコンストラクタ
        /// <param name="vCode">商品コード</param>
        /// <param name="vName">商品名</param>
        /// <param name="vPrice">商品価格（税抜き</param>
        public Product(int vCode, string vName, int vPrice) {
            this.Code = vCode;
            this.Name = vName;
            this.Price = vPrice;
        }
        /// <summary>
        /// 消費税を求める（消費税率は10%）
        /// /// </summary>
        /// 商品価格の消費税をを消費税10%で計算した値
        /// <returns>int</returns>
        public int GetTax() {
            return (int)Math.Round(Price * 0.1);
        }
    }
}
