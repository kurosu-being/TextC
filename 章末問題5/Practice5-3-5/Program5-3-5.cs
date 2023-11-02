using System;
using System.Text;

namespace Practice5_3_5 {
    /*　Practice5-3-5 空白で区切り、配列に格納した後、StringBuilderクラスを使い文字列を連結させ、
    　　元の文字列と同じものを作りだしてください。元の文字列の中には連続した空白は存在しないものとします。*/
    class Program {
        static void Main(string[] args) {
            string wSentence = "Jackdaws love my big sphinx quartz";
            string[] wWords = wSentence.Split(' ');
            var wBuilder = new StringBuilder();
            foreach (var wWord in wWords) {
                wBuilder.AppendFormat($" {wWord}", wWord);
            }

            Console.WriteLine(wBuilder.ToString().TrimStart());
        }
    }
}
