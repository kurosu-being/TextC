namespace Practice2_1_4 {
    /// <summary>
    /// 時間計算のクラス
    /// </summary>
    class Calculator {
        /// <summary>
        /// 分を計算するメソッド
        /// </summary>
        /// <param name="vLength">曲の長さ</param>
        /// <returns>曲の分/returns>
        public static int ConvertMinute(int vLength) {
            return vLength / 60;
        }
        /// <summary>
        /// 秒数を計算するメソッド
        /// </summary>
        /// <param name="vLength">曲の長さ</param>
        /// <returns>曲の秒数</returns>
        public static int ConvertSecond(int vLength) {
            return vLength % 60;
        }
    }
}
