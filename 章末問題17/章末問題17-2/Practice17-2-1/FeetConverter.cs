namespace Practice17_2_1 {
    //単位：フィートのクラス
    public class FeetConverter : ConverterBase {
        public override bool IsMyUnit(string vName) {
            return vName.ToLower() == "feet" || vName == UnitName;
        }
        protected override double Ratio { get { return 0.3048; } }
        public override string UnitName { get { return "フィート"; } }
    }
}
