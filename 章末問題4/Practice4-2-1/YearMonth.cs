namespace Practice4_2_1 {
    /// <summary>
    /// 年(Year)と月(Month)の2つのプロパティを持つクラス
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
        public int Is21Century { get; set; }
        /// <summary>
        /// コンストラクタ
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
            int wNewMonth = this.Month++;
            if (wNewMonth > 12) {
                wNewMonth = 1;
                wNewYear++;
            }
            return new YearMonth(wNewYear, wNewMonth);
        }
        public override string ToString() {
            return ($"{Year}年{Month}月 ");
        }
    }
}