using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Practice12_2_2 {
    [Serializable]
    [XmlRoot("novelist")]
    public class Novelist {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "birth")]
        public string BirthString {
            get { return Birth.ToString("yyyy-MM-ddTHH:mm:ssZ"); }
            set { Birth = DateTime.Parse(value); }
        }

        [XmlArray("masterpieces")]
        [XmlArrayItem("title")]
        public string[] Masterpieces { get; set; }

        [XmlIgnore]
        public DateTime Birth { get; set; }
    }
}