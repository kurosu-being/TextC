using System.Linq;

namespace Practice5_4_1_Split {
    class Novelist {
        /// <summary>
        /// 作家
        /// </summary>
        public string Writer { get; private set; }
        /// <summary>
        /// 代表作
        /// </summary>
        public string BestWork { get; private set; }
        /// <summary>
        /// 誕生年
        /// </summary>
        public int Born { get; private set; }
        /// <summary>
        /// Novelistクラスのコンストラクタ
        /// </summary>
        /// <param name="vSentence">受け取る文字列</param>
        public Novelist(string vSentence) {
            var parts = vSentence.Split(';')
                .Select(x => x.Split('='))
                .ToDictionary(p => p[0], p => p[1]);
            if (parts.ContainsKey("Novelist"))
                this.Writer = parts["Novelist"];
            if (parts.ContainsKey("BestWork"))
                this.BestWork = parts["BestWork"];
            if (parts.ContainsKey("Born") && int.TryParse(parts["Born"], out int wBornYear))
                this.Born = wBornYear;
        }
    }
}
