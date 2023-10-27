namespace Practice4_2_3 {
    /// <summary>
    /// 年月計算クラス
    /// </summary>
    class YearMonth {
        /// <summary>
        /// 年
        /// </summary>
        public int Year { get; private set; }
        /// <summary>
        /// 月
        /// </summary>
        public int Month { get; private set; }
        /// <summary>
        /// 21世紀
        /// </summary>
        public bool Is21stCentury {
            get {
                return Year >= 2001 && Year <= 2100;
            }
        }
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
        /// <returns>1か月後の年と日</returns>
        public YearMonth AddOneMonth() {
            int wNewYear = this.Year;
            int wNewMonth = this.Month + 1;
            if (wNewMonth > 12) {
                wNewMonth = 1;
                ++wNewYear;
            }
            return new YearMonth(wNewYear, wNewMonth);
        }
        /// <summary>
        /// 書式を"2017年8月"の形に直すメソッド
        /// </summary>
        /// <returns>指定書式に変更した年月</returns>
        public override string ToString() {
            return ($"{Year}年{Month}月 ");
        }
        /// <summary>
        /// 21世紀の年月を探すメソッド
        /// </summary>
        /// <param name="wYearMonths">年月</param>
        /// <returns>21世紀の年月</returns>
        public static YearMonth FindFirst21YearMonth(YearMonth[] wYearMonths) {
            foreach (YearMonth wYearMonth in wYearMonths) {
                if (wYearMonth.Is21stCentury) {
                    return wYearMonth;
                }
            }
            return null;
        }
    }
}

