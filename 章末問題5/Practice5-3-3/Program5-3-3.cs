using System;

namespace Practice5_3_3 {
    //Practice5-3-2 単語がいくつあるかカウントしてください。
    class Program {
        static void Main(string[] args) {
            string wSentence = "Jackdaws love my big sphinx quartz.";
            string[] wWord = wSentence.Split(' ');
            //
            Console.WriteLine(wWord.Length);
        }
    }
}
