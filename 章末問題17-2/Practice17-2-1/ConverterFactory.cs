using System.Linq;

namespace Practice17_2_1 {
    static class ConverterFactory {
        //あらかじめインスタンスを生成し、配列に入れておく
        private static ConverterBase[] FConverters = new ConverterBase[]{
            new MeterConverter(),
            new FeetConverter(),
            new YardConverter(),
            new InchConverter(),
            new MileConverter(),
            new KilometerConverter(),
        };

        /// <summary>
        /// 単位を判定し、ポリモーフィズムで単位名を返す
        /// </summary>
        /// <param name="vName">指定された文字列</param>
        /// <returns>単位名</returns>
        public static ConverterBase GetInstance(string vName) {
            return FConverters.FirstOrDefault(x => x.IsMyUnit(vName));
        }
    }
}
