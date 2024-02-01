using System;

namespace Practice17_2_1 {
    //Practice17-2-1 テキストのStrategyパターンで示した距離換算プログラムに機能を追加し、マイルとキロメートルも扱えるようにしてください。
    class Program {
        static void Main(string[] args) {
            while (true) {
                var wFrom = GetConverter("変換元の単位を入力してください。");
                var wTo = GetConverter("変換先の単位を入力してください。");
                var wDistance = GetDistance(wFrom);

                var wConverter = new DistanceConverter(wFrom, wTo);
                var wResult = wConverter.Convert(wDistance);
                Console.WriteLine($"{wDistance}{wFrom.UnitName}は{wResult:0.000}{wTo.UnitName}です{Environment.NewLine}");
            }
        }

        /// <summary>
        /// 単位情報を変換するメソッド
        /// </summary>
        /// <param name="vMessage">入力された単位</param>
        /// <returns>単位</returns>
        static ConverterBase GetConverter(string vMessage) {
            ConverterBase wConverter = null;
            do {
                Console.WriteLine(vMessage + " => ");
                var wUnit = Console.ReadLine();
                wConverter = ConverterFactory.GetInstance(wUnit);
            } while (wConverter == null);
            return wConverter;
        }

        /// <summary>
        /// 距離を得るメソッド
        /// </summary>
        /// <param name="vFrom">入力された距離</param>
        /// <returns>距離</returns>
        static double GetDistance(ConverterBase vFrom) {
            double? wValue = null;
            do {
                Console.WriteLine($"変換したい距離(単位:{vFrom.UnitName}を入力してください => )");
                var wLine = Console.ReadLine();
                double temp;
                wValue = double.TryParse(wLine, out temp) ? (double?)temp : null;
            } while (wValue == null);
            return wValue.Value;
        }
    }
}
