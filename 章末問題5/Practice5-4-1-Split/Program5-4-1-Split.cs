using System;

namespace Practice5_4_1_Split {
    class Program {
        static void Main(string[] args) {
            string wSentence = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";

            string[] wParts = wSentence.Split(';');
            string wNovelist = GetPartsValue(wParts, "Novelist");
            string wBestWork = GetPartsValue(wParts, "BestWork");
            string wBorn = GetPartsValue(wParts, "Born");

            Console.WriteLine($"作家  : {wNovelist}");
            Console.WriteLine($"代表作: {wBestWork}");
            Console.WriteLine($"誕生年: {wBorn}年");

            //追加のお題（wNovelistを既に使っているのでwNovelistTに命名を変更しています）
            var wNovelistT = new Novelist(wSentence);

            Console.WriteLine($"作家  : {wNovelistT.Name}");
            Console.WriteLine($"代表作: {wNovelistT.BestWork}");
            Console.WriteLine($"誕生年: {wNovelistT.Born}年");
        }
        /// <summary>
        /// Keyに対応するValueを探すメソッド
        /// </summary>
        /// <param name="vParts">受け取る文字列</param>
        /// <param name="vKey">探すKey</param>
        /// <returns>Keyに対応するValue</returns>
        static string GetPartsValue(string[] vParts, string vKey) {
            foreach (string wPart in vParts) {
                string[] wKeyValue = wPart.Split('=');
                if (wKeyValue.Length == 2 && wKeyValue[0] == vKey) {
                    return wKeyValue[1];
                }
            }
            return "見つかりません";
        }
    }
}
