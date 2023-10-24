namespace Practice2_2_1 {
    /// <summary>
    /// インチからメートル変換するクラス
    /// </summary>
    public static class InchConverter {
        private const double C_Ratio = 0.0254;

        /// <summary>
        /// インチからメートルを求めるメソッド
        /// </summary>
        /// <param name="vMeter">メートル距離</param>
        /// <returns>インチ距離</returns>
        public static double ToMeter(double vMeter) {
            return vMeter * C_Ratio;
        }
    }
}
