using System;
using System.Linq;

namespace Practice5_3_4 {
    // 4文字以下の単語を列挙してください。
    class Program {
        static void Main(string[] args) {
            string wSentence = "Jackdaws love my big sphinx quartz";
            string[] wWords = wSentence.Split(' ');
            var wUnderFourWords = wWords.Where(x => x.Length <= 4);
            foreach (var wWord in wUnderFourWords) {
                Console.WriteLine(wWord);
            }
        }
    }
}
