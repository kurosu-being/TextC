using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Practice10_2_1 {
    //Practice10-2-1 テキストファイルを読み込み三文字以上の文字だけから成る部分文字列をすべて抜き出すコードを書いてください。
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("テキストファイルのパスを書いてください");
            var wFilePath = Console.ReadLine();

            if (!File.Exists(wFilePath)) {
                Console.WriteLine("ファイルが存在しません");
                return;
            }

            string wText = File.ReadAllText(wFilePath);

            List<string> wSubstrings = PickNumbers(wText);

            if (wSubstrings.Count > 0) {
                Console.WriteLine("3文字以上の部分文字列:");
                foreach (string wSubstring in wSubstrings) {
                    Console.WriteLine(wSubstring);
                }
            } else {
                Console.WriteLine("3文字以上の部分文字列が見つかりませんでした。");
            }
        }
        static List<string> PickNumbers(string vText) {

            var wMatches = Regex.Matches(vText, @"\b(?![0-9])\w{3,}\b");
            var wSubstrings = new List<string>();

            foreach (Match wMatch in wMatches) {
                wSubstrings.Add(wMatch.Value);
            }

            return wSubstrings;
        }
    }
}
