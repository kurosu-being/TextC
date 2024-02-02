namespace Practice17_2_1 {
    //単位：メートルのクラス
    public class MeterConverter : ConverterBase {
        public override bool IsMyUnit(string vName) {
            return vName.ToLower() == "meter" || vName == UnitName;
        }
        protected override double Ratio { get { return 1; } }
        public override string UnitName { get { return "メートル"; } }
    }
}
