using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice7_2_1 {
    class Abbreviations {
        private Dictionary<string, string> _FDict = new Dictionary<string, string>();

        public Abbreviations(){
            var wLines = FileStyleUriParser.ReadAllLines("Abbreviations.txt");
        }
    }
}
