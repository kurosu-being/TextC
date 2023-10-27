using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Practice2_3_1 {
    /// <summary>
    /// 売上計算のクラス
    /// </summary>
    public class SalesCounter {
        private readonly IEnumerable<Sale> FSales;
        /// <summary>
        /// CountSalesのコンストラクタ
        /// </summary>
        /// <param name="vFilePath"></param>
        public SalesCounter(string vFilePath) {
            FSales = ReadSales(vFilePath);
        }
        /// <summary>
        /// 売上データを読み込み、Saleオブジェクトのリストを返す
        /// </summary>
        /// <param name="vFilePath">売上データ</param>
        /// <returns>Saleオブジェクトのリスト</returns>
        private static IEnumerable<Sale> ReadSales(string vFilePath) {
            var wSales = new List<Sale>();
            foreach (string wLine in File.ReadLines(vFilePath)) {
                var wItems = wLine.Split(',');
                var wSale = new Sale(wItems[0], wItems[1], int.Parse(wItems[2]));
                wSales.Add(wSale);
            }
            return wSales;
        }
        /// <summary>
        /// 商品カテゴリ別売上を求めるメソッド
        /// </summary>
        /// <returns>商品カテゴリ別売上</returns>
        public IDictionary<string, int> GetPerItemSales() => FSales.GroupBy(x => x.ProductCategory)
                   .ToDictionary(x => x.Key, x => x.Sum(s => s.Amount));
    }
}
