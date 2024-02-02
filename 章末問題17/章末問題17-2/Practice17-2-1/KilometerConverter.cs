namespace Practice17_2_1 {
    //単位：キロメートルのクラス
    public class KilometerConverter : ConverterBase {
        public override bool IsMyUnit(string vName) {
            return vName.ToLower() == "kilometer" || vName == UnitName;
        }
        protected override double Ratio { get { return 1000; } }
        public override string UnitName { get { return "キロメートル"; } }
    }
}
