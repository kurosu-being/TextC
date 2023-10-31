using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5_3_5 {
    class Program {
        static void Main(string[] args) {
            string wSentence = "Jackdaws love my big sphinx quartz";
            string[] wWords = wSentence.Split(' ');
            var wStringBuilderObject = new StringBuilder();
            foreach (var wWord in wWords){
                wStringBuilderObject.AppendFormat($" {wWord}",wWord);
            }
            var wJoinWords = wStringBuilderObject.ToString();
            var wReplaced = wJoinWords.TrimStart();
            Console.WriteLine(wReplaced);
        }
    }
}
