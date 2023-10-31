using System;

namespace Practice5_3_2 {
    //Practice5-3-2　文字列の中の"big"という部分文字列を"small"に置き換えてください。
    class Program {
        static void Main(string[] args) {
            string wSentence = "Jackdaws love my big sphinx quartz.";
            string wReplaced = wSentence.Replace("big", "small");
            Console.WriteLine(wReplaced);
        }
    }
}
