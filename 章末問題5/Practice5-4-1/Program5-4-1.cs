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
            /*正規表現について理解が不安な部分があるので、
            自分の考えを書き記します。間違いがある場合はご指摘頂けると幸いです。
            使用した正規表現
            (.*?) : '.' が任意の1文字を表し、*? という組み合わせで、文字列が部分一致することを示します。
            (;|$) ;  ';'または文字列の終わりであることを示します

            この表現によりwMatch に一致する部分を格納し、その値を wMatch.Groups[1].Value で取得しています。*/
            string wPattern = $"{vKey}=(.*?)(;|$)";

            Match wMatch = Regex.Match(vSentence, wPattern);
            return wMatch.Success ? wMatch.Groups[1].Value : "見つかりません";
        }

    }
}
