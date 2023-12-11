﻿using System;
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
        public string BirthString 
        {
            get { return Birth.ToString("yyyy-MM-dd"); }
            set { Birth = DateTime.Parse(value); }
        }

        [XmlArray("masterpieces")]
        [XmlArrayItem("title")] 
        public string[] Masterpieces { get; set; }

        [XmlIgnore] 
        public DateTime Birth { get; set; }
    }
}