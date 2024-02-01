namespace Practice17_2_1 {
    //単位：インチのクラス
    public class InchConverter : ConverterBase {
        public override bool IsMyUnit(string vName) {
            return vName.ToLower() == "inch" || vName == UnitName;
        }
        protected override double Ratio { get { return 0.0254; } }
        public override string UnitName { get { return "インチ"; } }
    }
}
