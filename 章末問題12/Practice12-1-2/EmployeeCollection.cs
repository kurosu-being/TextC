using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Practice12_1_1;

namespace Practice12_1_2 {
    /// <summary>
    /// 従業員のクラス
    /// </summary>
    [XmlRoot("employees")]
    public class EmployeeCollection {
        [XmlElement(Type = typeof(Employee), ElementName = "employee")]
        public Employee[] Employees { get; set;}     
        }
    }

