using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Practice12_1_4 {
    /// <summary>
    /// 従業員のクラス
    /// </summary>
    [DataContract(Name = "employee")]
    public class Employee {
        /// <summary>
        /// ID
        /// </summary>
        [XmlIgnore]
        public int ID { get; set; }
        /// <summary>
        /// 名前
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }
        /// <summary>
        /// 入社日
        /// </summary>
        [DataMember(Name = "hiredate")]
        public DateTime HireDate { get; set; }

        //コンストラクタ
        public Employee(int vID, string vName, DateTime vHireDate) {
            this.ID = vID;
            this.Name = vName;
            this.HireDate = vHireDate;
        }
    }
}
