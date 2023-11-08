using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Practice7_2_3 {
    /// <summary>
    /// 省略語のクラス
    /// </summary>
    class Abbreviations {
        // ディクショナリの初期化
        private Dictionary<string, string> FDict = new Dictionary<string, string>();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Abbreviations(string vFilePath) {
            var wLines = File.ReadAllLines(vFilePath);
            FDict = wLines.Select(x => x.Split('=')).ToDictionary(x => x[0], x => x[1]);
        }

        /// <summary>
        /// 要素を追加するメソッド
        /// </summary>
        /// <param name="vAbbr">要素のキー</param>
        /// <param name="vJapanese">要素の値</param>
        public void Add(string vAbbr, string vJapanese) {
            FDict[vAbbr] = vJapanese;
        }

        /// <summary>
        ///インデクサ-省略語をキーに取る
        /// </summary>
        /// <param name="vAbbr">省略語</param>
        /// <returns>正式名</returns>
        public string this[string vAbbr] {
            get {
                return FDict.ContainsKey(vAbbr) ? FDict[vAbbr] : null;
            }
        }

        /// <summary>
        /// 日本語から省略語を取り出すメソッド
        /// </summary>
        /// <param name="japanese">日本語</param>
        /// <returns>省略語</returns>
        public string ToAbbreviation(string japanese) {
            return FDict.FirstOrDefault(x => x.Value == japanese).Key;
        }

        /// <summary>
        /// 日本語の位置を引数に与え、それが含まれる要素（Key、Value）をすべて取り出すメソッド
        /// </summary>
        /// <param name="wSubstring">日本語の位置</param>
        /// <returns>それが含まれる要素</returns>
        public IEnumerable<KeyValuePair<string, string>> FindAll(string wSubstring) {
            foreach (var wItem in FDict) {
                if (wItem.Value.Contains(wSubstring))
                    yield return wItem;
            }
        }

        /// <summary>
        /// ディクショナリに登録されている用語の数を返すプロパティ
        /// </summary>
        public int Count => FDict.Count;

        /// <summary>
        /// 省略語を削除するメソッド
        /// </summary>
        /// <param name="vAbbr">削除する省略語</param>
        /// <returns>指定した省略後を削除したディクショナリ</returns> 
        public bool Remove(string vAbbr) => FDict.Remove(vAbbr);
    }
}