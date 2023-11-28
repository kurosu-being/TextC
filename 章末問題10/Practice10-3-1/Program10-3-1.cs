using System;
using System.Text.RegularExpressions;

namespace Practice10_3_1 {
    //Practice10-3-1 以下の文字列から、単語"time"が含まれる文字列を取り出し、timeの開始位置をすべて出力してください。大文字/小文字の区別なく検索してください。
    /* 
    var texts = new[] {
    "Time is money.",
    "What time is it?",
    "It will take time.",
    "We reorganized the timetable",
    }
    */
    class Program {
        static void Main(string[] args) {
            var wTexts = new[] {
                "Time is money.",
                "What time is it?",
                "It will take time.",
                "We reorganized the timetable",
            };

            var wPattern = @"\btime\b";

            foreach (var wText in wTexts) {
                MatchCollection wMatches = Regex.Matches(wText, wPattern, RegexOptions.IgnoreCase);
                foreach (Match wMatch in wMatches) {
                    Console.WriteLine(wMatch.Index);
                }
            }
        }
    }
}

