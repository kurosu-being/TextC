using System.Linq;

namespace Practice5_3_1 {
    /* "Jackdaws love my big sphinx quartz."という文字列があります。この文字列に対して、
       以下の問題を解いてください
       Practice5-3-1 空文字が何文字あるかカウントしてください　*/

    class Program {
        static void Main(string[] args) {
            string wSentence = "Jackdaws love my big sphinx quartz.";
            int wCount = wSentence.Count(x => x == ' ');
        }
    }
}
