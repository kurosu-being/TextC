namespace Practice2_2_1 {
    public static class ConvertInch {
        private const double C_Ratio = 0.0254;

        /// <summary>
        /// インチからメートルを求めるメソッド
        /// </summary>
        /// <param name="vMeter">メートル距離</param>
        /// <returns>インチ距離</returns>
        public static double FromMeter(double vMeter) {
            return vMeter * 0.0254;
        }
    }
}
