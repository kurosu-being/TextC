namespace Practice17_2_1 {
    //距離の変換に関する機能を提供するクラス
    public class DistanceConverter {
        public ConverterBase From { get; private set; }
        public ConverterBase To { get; private set; }

        //コンストラクタ
        public DistanceConverter(ConverterBase vFrom, ConverterBase vTo) {
            From = vFrom;
            To = vTo;
        }
        //対象をメートルに換算し、メートルから指定の単位に換算するメソッド
        public double Convert(double vValue) {
            var wMeter = From.ToMeter(vValue);
            return To.FromMeter(wMeter);
        }
    }
}
