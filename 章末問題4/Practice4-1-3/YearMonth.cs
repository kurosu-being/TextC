namespace Practice4_1_3 {
    /// <summary>
    /// 年月計算クラス
    /// </summary>
    class YearMonth {
        /// <summary>
        /// 年
        /// </summary>
        public int Year { get; }
        /// <summary>
        /// 月
        /// </summary>
        public int Month { get; }
        /// <summary>
        /// 21世紀
        /// </summary>
        public bool Is21stCentury => 2001 <= Year && Year <= 2100;
        /// <summary>
        /// YearMonthのコンストラクタ
        /// </summary>
        /// <param name="vYear">年</param>
        /// <param name="vMonth">月</param>
        public YearMonth(int vYear, int vMonth) {
            this.Year = vYear;
            this.Month = vMonth;
        }
        /// <summary>
        /// 1か月後を求めるメソッド
        /// </summary>
        /// <returns>1か月後の年と月</returns>
        public YearMonth AddOneMonth() {
            int wNewYear = this.Year;
            int wNewMonth = this.Month + 1;

            if (wNewMonth > 12) {
                wNewMonth = 1;
                ++wNewYear;
            }
            return new YearMonth(wNewYear, wNewMonth);
        }
    }
}

