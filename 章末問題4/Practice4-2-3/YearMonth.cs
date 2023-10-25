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
            set { Is21stCentury = value; }
        }
        /// <summary>
        /// YearMonthのYearMonthのコンストラクタ
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
        public void AddOneMonth() {
            this.Month++;
            if (this.Month > 12) {
                this.Month = 1;
                this.Year++;
            }
        }
        public override string ToString() {
            return ($"{Year}年{Month}月 ");
        }
    }
}

