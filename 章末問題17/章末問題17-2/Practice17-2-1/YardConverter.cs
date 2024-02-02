namespace Practice17_2_1 {
    //単位：ヤードのクラス
    public class YardConverter : ConverterBase {
        public override bool IsMyUnit(string vName) {
            return vName.ToLower() == "yard" || vName == UnitName;
        }
        /// <summary>
        /// 比率
        /// </summary>
        protected override double Ratio { get { return 0.9144; } }
        /// <summary>
        /// 単位
        /// </summary>
        public override string UnitName { get { return "ヤード"; } }
    }
}