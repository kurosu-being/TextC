using System;

namespace Practice12_1_1 {
    /// <summary>
    /// 従業員のクラス
    /// </summary>
    public class Employee {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 入社日
        /// </summary>
        public DateTime HireDate { get; set; }

        /// <summary>
        /// 従業員のコンストラクタ
        /// </summary>
        /// <returns>フォーマットに直した形</returns>
        public override string ToString() {
            return string.Format($"[ID={ID},Name={Name},HireDate={HireDate:d}]");
        }
    }
}
