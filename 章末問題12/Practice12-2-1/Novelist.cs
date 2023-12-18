using System;
using System.Xml.Serialization;

namespace Practice12_2_1 {
    /// <summary>
    /// 作家のクラス
    /// </summary>
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
        public string BirthString 
        {
            get { return Birth.ToString("yyyy-MM-dd"); }
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