using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice12_1_2 {
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

        public override string ToString() {
            return string.Format($"[ID={ID},Name={Name},HireDate={HireDate:d}]");
        }
    }
}