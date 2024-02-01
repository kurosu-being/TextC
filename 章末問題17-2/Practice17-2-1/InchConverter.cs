using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice17_2_1 {
    public class InchConverter : ConverterBase {
        public override bool IsMyUnit(string vName) {
            return vName.ToLower() == "inch" || vName == UnitName;
        }
        protected override double Ratio { get { return 0.0254; } }
        public override string UnitName { get { return "インチ"; } }
    }
}
