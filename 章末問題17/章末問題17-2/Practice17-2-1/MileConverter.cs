namespace Practice17_2_1 {
    //単位：マイルのクラス
    public class MileConverter : ConverterBase {
        public override bool IsMyUnit(string vName) {
            return vName.ToLower() == "mile" || vName == UnitName;
        }
        /// <summary>
        /// 比率
        /// </summary>
        protected override double Ratio { get { return 1609.344; } }
        /// <summary>
        /// 単位
        /// </summary>
        public override string UnitName { get { return "マイル"; } }
    }
}
