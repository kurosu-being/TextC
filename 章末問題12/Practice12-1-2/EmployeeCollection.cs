using Practice12_1_1;
using System.Xml.Serialization;

namespace Practice12_1_2 {
    /// <summary>
    /// 従業員のコレクションのクラス
    /// </summary>
    [XmlRoot("employees")]
    public class EmployeeCollection {
        /// <summary>
        /// 従業員のコレクション
        /// </summary>
        [XmlElement(Type = typeof(Employee), ElementName = "employee")]
        public Employee[] Employees { get; set; }
    }
}

