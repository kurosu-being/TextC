using System;
using System.Xml.Serialization;

namespace Practice12_2_1 {
    /// <summary>
    /// 作家のクラス
    /// </summary>
    [XmlRoot("novelist")]
    public class Novelist {
      
    [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "birth")]
        public string BirthString // 生年月日を文字列として読み込む
        {
            get { return Birth.ToString("yyyy-MM-dd"); }
            set { Birth = DateTime.Parse(value); }
        }

        [XmlArray("masterpieces")]
        [XmlArrayItem("title")] // 各タイトルを title 要素として指定
        public string[] Masterpieces { get; set; }

        [XmlIgnore] // BirthString はシリアライズ対象外にする
        public DateTime Birth { get; set; }
    }
}