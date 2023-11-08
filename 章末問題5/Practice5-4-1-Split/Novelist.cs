using System.Linq;

namespace Practice5_4_1_Split {
    /// <summary>
    /// 作家のクラス
    /// </summary>
    class Novelist {
        /// <summary>
        /// 作家の名前
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// 代表作
        /// </summary>
        public string BestWork { get; }
        /// <summary>
        /// 誕生年
        /// </summary>
        public int Born { get; }
        /// <summary>
        /// Novelistクラスのコンストラクタ
        /// </summary>
        /// <param name="vSentence">受け取る文字列</param>
        public Novelist(string vSentence) {
            var wParts = vSentence.Split(';')
                .Select(x => x.Split('='))
                .ToDictionary(p => p[0], p => p[1]);
            if (wParts.ContainsKey("Novelist"))
                this.Name = wParts["Novelist"];
            if (wParts.ContainsKey("BestWork"))
                this.BestWork = wParts["BestWork"];
            if (wParts.ContainsKey("Born") && int.TryParse(wParts["Born"], out int wBornYear))
                this.Born = wBornYear;
        }
    }
}
