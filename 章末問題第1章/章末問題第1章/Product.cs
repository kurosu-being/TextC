using System;

namespace Henkou {
    public class Product {
        /// <summary>
        /// 商品コード
        /// </summary>
        public int Code { get;}
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
        /// </summary>
        /// 商品コードの引数
        /// <param name="vCode"></param>
        /// 商品名の引数
        /// <param name="vName"></param>
        /// 商品価格（税抜き）の引数
        /// <param name="vPrice"></param>
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
