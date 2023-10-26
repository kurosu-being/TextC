﻿using System;

namespace Practice4_2_3 {
    class Program {
        //Practice4-2-3 配列の中の最初に見つかった21世紀のYearMonthオブジェクトを返すメソッドを書いてください。見つからなかった場合は、nullを返してください。foreach文を使って実装してください。
        static void Main(string[] args) {
            var wDay1 = new YearMonth(2000, 3);
            var wDay2 = new YearMonth(2005, 12);
            var wDay3 = new YearMonth(2005, 2);
            var wDay4 = new YearMonth(2023, 10);
            var wDay5 = new YearMonth(2045, 7);
            var wYearMonths = new YearMonth[] { wDay1, wDay2, wDay3, wDay4, wDay5, };
            var wFirst21YearMonth = FindFirst21YearMonth(wYearMonths);
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
