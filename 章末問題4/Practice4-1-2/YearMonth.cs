namespace Practice4_1_2 {
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
    }
}

