using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5_4_1 {
    /*　"Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886"という文字列から
    以下の出力を得るコンソールアプリケーションを作成してください。
    作家  : 谷崎潤一郎
    代表作: 春琴抄
    誕生年: 1886年*/
    class Program {
        static void Main(string[] args) {
            string wSentence = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
            var wNovelistValue = "Novelist=";
            var wBestWorkValue = "BestWork=";
            var wBornValue = "Born=";
            //Novelistを抽出
            var wNovelistStartIndex = wSentence.IndexOf("Novelist=") + wNovelistValue.Length;
            int wNovelistEndIndex = wSentence.IndexOf(';',wNovelistStartIndex);
            string wNovelist = wSentence.Substring(wNovelistStartIndex,wNovelistEndIndex - wNovelistStartIndex);
            //BestWorkを抽出
            var wBestWorkStartIndex = wSentence.IndexOf("BestWork=") + wBestWorkValue.Length;
            int wBestWorkEndIndex = wSentence.IndexOf(';', wBestWorkStartIndex);
            string wBestWork = wSentence.Substring(wBestWorkStartIndex, wBestWorkEndIndex - wBestWorkStartIndex);
            //Bornを抽出
            var wBornStartIndex = wSentence.IndexOf("Born=") + wBornValue.Length;
            int wBornEndIndex = wSentence.IndexOf(';', wBornStartIndex);
            string wBorn = wSentence.Substring(wBornStartIndex, wBornEndIndex - wBornStartIndex);

            Console.WriteLine($"作家  : {wNovelist}");
            Console.WriteLine($"代表作: {wBestWork}");
            Console.WriteLine($"誕生年: {wBorn}");
        }
    }
}
