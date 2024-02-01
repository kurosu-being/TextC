using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice17_2_1 {
    public class MileConverter : ConverterBase {
        public override bool IsMyUnit(string vName) {
            return vName.ToLower() == "mile" || vName == UnitName;
        }
        protected override double Ratio { get { return 1609.344; } }
        public override string UnitName { get { return "マイル"; } }
    }
}
