namespace Practice17_2_1 {
    //単位：キロメートルのクラス
    public class KilometerConverter : ConverterBase {
        public override bool IsMyUnit(string vName) {
            return vName.ToLower() == "kilometer" || vName == UnitName;
        }
        /// <summary>
        /// 比率
        /// </summary>
        protected override double Ratio { get { return 1000; } }
        /// <summary>
        /// 単位
        /// </summary>
        public override string UnitName { get { return "キロメートル"; } }
    }
}
