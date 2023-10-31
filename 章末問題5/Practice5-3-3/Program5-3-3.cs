using System;

namespace Practice5_3_3 {
    //Practice5-3-2 単語がいくつあるかカウントしてください。
    class Program {
        static void Main(string[] args) {
            string wSentence = "Jackdaws love my big sphinx quartz";
            string[] wWords = wSentence.Split(' ');
            //単語数（wWord.Length）を表示
            Console.WriteLine(wWords.Length);
        }
    }
}
