using System.Collections.Generic;
using System.IO;

namespace Practice2_3_1 {
    public class CountSales {
        private IEnumerable<Sale> ISales;

        /// <summary>
        /// CountSalesのコンストラクタ
        /// </summary>
        /// <param name="vFilePath"></param>
        public CountSales(string vFilePath) {
            ISales = ReadSales(vFilePath);
        }
        /// <summary>
        /// 売上データを読み込み、Saleオブジェクトのリストを返す
        /// </summary>
        /// <param name="vFilePath">売上データ</param>
        /// <returns>Saleオブジェクトのリスト</returns>
        private static IEnumerable<Sale> ReadSales(string vFilePath) {
            var wSales = new List<Sale>();
            var wLines = File.ReadLines(vFilePath);
            foreach (var Line in wLines) {
                var wItems = Line.Split(',');
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
            foreach (var sale in ISales) {
                if (wDict.ContainsKey(sale.ProductCategory))
                    wDict[sale.ProductCategory] += sale.Amount;
                else
                    wDict[sale.ProductCategory] = sale.Amount;
            }
            return wDict;
        }
    }
}
