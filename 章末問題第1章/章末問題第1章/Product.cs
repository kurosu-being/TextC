﻿namespace Henkou {
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
        /// 商品コード
        /// <param name="vCode"></param>
        /// 商品名
        /// <param name="vName"></param>
        /// 商品価格（税抜き）
        /// <param name="vPrice"></param>
        public Product(int vCode, string vName, int vPrice) {
            this.Code = vCode;
            this.Name = vName;
            this.Price = vPrice;
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
