using System;

namespace Practice5_3_1 {
    /* "Jackdaws love my big sphinx quartz."という文字列があります。この文字列に対して、
       以下の問題を解いてください
       Practice5-3-1 空白が何文字あるかカウントしてください　*/

    class Program {
        static void Main(string[] args) {
            //確認の為、空白に半角スペース、全角スペース、Tabスペースを使用しています
            string wSentence = "Jackdaws love my big　sphinx quartz";
            int wCount = CountSpaces(wSentence);

            Console.WriteLine($"空白文字の個数: {wCount}");
        }
        /// <summary>
        /// 空白をカウントするメソッド
        /// </summary>
        /// <param name="vInput">受けとる文字列</param>
        /// <returns>空白の個数</returns>
        static int CountSpaces(string vInput) {
            int wCount = 0;
            foreach (char wChar in vInput) {
                if (char.IsWhiteSpace(wChar)) {
                    wCount++;
                }
            }
            return wCount;
        }
    }
}