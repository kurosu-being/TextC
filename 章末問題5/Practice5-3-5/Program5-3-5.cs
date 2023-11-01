using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5_3_5 {
    /*　Practice5-3-5 空白で区切り、配列に格納した後、StringBuilderクラスを使い文字列を連結させ、
    　　元の文字列と同じものを作りだしてください。元の文字列の中には連続した空白は存在しないものとします。*/
    class Program {
        static void Main(string[] args) {
            string wSentence = "Jackdaws love my big sphinx quartz";
            string[] wWords = wSentence.Split(' ');
            //wStringBuilderObject　←適切な命名が思いつきませんでした
            var wStringBuilderObject = new StringBuilder();
            foreach (var wWord in wWords){
                wStringBuilderObject.AppendFormat($" {wWord}",wWord);
            }
            var wJoinWords = wStringBuilderObject.ToString();
            var wDeletStartSpaces = wJoinWords.TrimStart();
            Console.WriteLine(wDeletStartSpaces);
        }
    }
}
