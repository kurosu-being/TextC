using System;
using System.Text.RegularExpressions;

namespace Practice5_4_1 {
    /*　Practice5-4-1 "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886"という文字列から
    以下の出力を得るコンソールアプリケーションを作成してください。
    作家  : 谷崎潤一郎
    代表作: 春琴抄
    誕生年: 1886年*/
    class Program {
        static void Main(string[] args) {
            string wSentence = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
            //Dictionaryに格納することも検討しましたが、"誕生年: {wBorn}年"だけコンソール表示方法が他2つと異なる為、このコードにしました。
            string wNovelist = GetValueFromSentence(wSentence, "Novelist");
            string wBestWork = GetValueFromSentence(wSentence, "BestWork");
            string wBorn = GetValueFromSentence(wSentence, "Born");

            Console.WriteLine($"作家  : {wNovelist}");
            Console.WriteLine($"代表作: {wBestWork}");
            Console.WriteLine($"誕生年: {wBorn}年");
        }

        /// <summary>
        /// 文章からKeyに対応するValueを探すメソッド
        /// </summary>
        /// <param name="vSentence">受け取る文章</param>
        /// <param name="vKey">探すKey</param>
        /// <returns>Keyに対応するValue</returns>
        static string GetValueFromSentence(string vSentence, string vKey) {
            string wPattern = $"{vKey}=(.*?)(;|$)";

            Match wMatch = Regex.Match(vSentence, wPattern);
            return wMatch.Success ? wMatch.Groups[1].Value : "見つかりません";
        }

    }
}
