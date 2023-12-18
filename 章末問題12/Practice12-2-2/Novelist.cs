using System;
using System.Xml.Serialization;

namespace Practice12_2_2 {
    /// <summary>
    /// 作家のクラス
    /// </summary>
    [Serializable]
    [XmlRoot("novelist")]
    public class Novelist {
        /// <summary>
        /// 著者名
        /// </summary>
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        /// <summary>
        /// 誕生日のフォーマット
        /// </summary>
        [XmlElement(ElementName = "birth")]
        public string BirthString {
            get { return Birth.ToString("yyyy-MM-ddTHH:mm:ssZ"); }
            set { Birth = DateTime.Parse(value); }
        }
        /// <summary>
        /// 著作
        /// </summary>
        [XmlArray("masterpieces")]
        [XmlArrayItem("title")]
        public string[] Masterpieces { get; set; }
        /// <summary>
        /// 誕生日
        /// </summary>
        [XmlIgnore]
        public DateTime Birth { get; set; }
    }
}
