using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Practice7_2_1 {
    /// <summary>
    /// 省略語のクラス
    /// </summary>
    class Abbreviations {
        readonly private Dictionary<string, string> FAbbreviationToJapanese = new Dictionary<string, string>();

        /// <summary>
        /// ディクショナリに登録されている用語の数を返すプロパティ
        /// </summary>
        public int Count => this.FAbbreviationToJapanese.Count;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Abbreviations(string vFilePath) {
            var wLines = File.ReadAllLines(vFilePath);
            FAbbreviationToJapanese = wLines.Select(x => x.Split('=')).ToDictionary(x => x[0], x => x[1]);
        }

        /// <summary>
        /// 省略語の日本語を追加するメソッド
        /// </summary>
        /// <param name="vKey">省略語</param>
        /// <param name="vJapanese">日本語</param>
        public void Add(string vKey, string vJapanese) => FAbbreviationToJapanese[vKey] = vJapanese;

        /// <summary>
        /// 省略語をキーに取るインデクサ
        /// </summary>
        /// <param name="vKey">省略語</param>
        /// <returns>キーに対応する日本語</returns>
        public string this[string vKey] => FAbbreviationToJapanese.TryGetValue(vKey, out string wValue) ? wValue : null;

        /// <summary>
        /// 日本語から省略語を取り出すメソッド
        /// </summary>
        /// <param name="vJapanese">日本語</param>
        /// <returns>省略語</returns>
        public string ToAbbreviation(string vJapanese) => FAbbreviationToJapanese.FirstOrDefault(x => x.Value == vJapanese).Key;

        /// <summary>
        /// 日本語の一部を引数に与え、それが含まれる要素（Key、Value）をすべて取り出すメソッド
        /// </summary>
        /// <param name="vSubstring">日本語の一部</param>
        /// <returns>含まれる要素（Key、Value）</returns>
        public IEnumerable<KeyValuePair<string, string>> FindAll(string vSubstring) {
            foreach (var wItem in FAbbreviationToJapanese) {
                if (wItem.Value.Contains(vSubstring))
                    yield return wItem;
            }
        }

        /// <summary>
        /// 省略語を削除するメソッド
        /// </summary>
        /// <param name="vKey">削除する省略語</param>
        /// <returns>指定した省略後を削除したディクショナリ</returns>
        public bool Remove(string vKey) => FAbbreviationToJapanese.Remove(vKey);
    }
}
