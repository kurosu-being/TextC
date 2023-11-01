using System;

namespace Practice4_2_5 {
    /// <summary>
    /// 年月計算クラス
    /// </summary>
    class YearMonth : IComparable<YearMonth> {
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
        /// 書式を"2017年8月"の形に直すメソッド
        /// </summary>
        /// <returns>指定書式に変更した年月</returns>
        public override string ToString() {
            return ($"{Year}年{Month}月 ");
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
        /// このオブジェクトと指定された別のオブジェクト（vOther）を比較し、大小関係を示す整数を返す
        /// </summary>
        /// <param name="vOther">判断する別のオブジェクト</param>
        /// <returns>判断した結果を表す数値</returns>
        public int CompareTo(YearMonth vOther) =>
            this.Year > vOther.Year ? 1
            : this.Year < vOther.Year ? -1
            : this.Month > vOther.Month ? 1
            : this.Month < vOther.Month ? -1
            : 0;
    }
}

