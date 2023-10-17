using System;

namespace Practice1._3_1 {
    class Person : object {
        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 日付
        /// </summary>
        public DateTime Birthday { get; set; }
        /// <summary>
        /// 今日と生まれた日を比較し、日付に応じて算出し年齢を取得するメソッド
        /// </summary>
        /// 今日と生まれた日を比較し、日付に応じて算出した年齢
        /// <returns>int</returns>
        public int GetAge() {
            DateTime wToday = DateTime.Today;
            int wAge = wToday.Year - Birthday.Year;
            if (wToday < Birthday.AddYears(wAge)) wAge--;
            return wAge;
        }
    }
}
