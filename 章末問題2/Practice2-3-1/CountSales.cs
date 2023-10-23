using System.Collections.Generic;
using System.IO;

namespace Practice2_3_1 {
    /// <summary>
    /// 売上計算のクラス
    /// </summary>
    public class CountSales {
        private IEnumerable<Sale> FSales;

        /// <summary>
        /// CountSalesのコンストラクタ
        /// </summary>
        /// <param name="vFilePath"></param>
        public CountSales(string vFilePath) {
            FSales = ReadSales(vFilePath);
        }
        /// <summary>
        /// 売上データを読み込み、Saleオブジェクトのリストを返す
        /// </summary>
        /// <param name="vFilePath">売上データ</param>
        /// <returns>Saleオブジェクトのリスト</returns>
        private static IEnumerable<Sale> ReadSales(string vFilePath) {
            var wSales = new List<Sale>();
            var wLines = File.ReadLines(vFilePath);
            foreach (var wLine in wLines) {
                var wItems = wLine.Split(',');
                var wSale = new Sale {
                    ShopName = wItems[0],
                    ProductCategory = wItems[1],
                    Amount = int.Parse(wItems[2])
                };
                wSales.Add(wSale);
            }
            return wSales;
        }
        /// <summary>
        /// 商品カテゴリ別売上を求めるメソッド
        /// </summary>
        /// <returns>商品カテゴリ別売上</returns>
        public IDictionary<string, int> GetPerItemSales() {
            var wDict = new Dictionary<string, int>();
            foreach (var wSale in FSales) {
                if (wDict.ContainsKey(wSale.ProductCategory))
                    wDict[wSale.ProductCategory] += wSale.Amount;
                else
                    wDict[wSale.ProductCategory] = wSale.Amount;
            }
            return wDict;
        }
    }
}
