using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Practice10_2_1 {
    //Practice10-2-1 テキストファイルを読み込み三文字以上の数字だけから成る部分文字列をすべて抜き出すコードを書いてください。
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("テキストファイルのパスを書いてください");
            var wFilePath = Console.ReadLine();

            if (string.IsNullOrEmpty(wFilePath)) {
                Console.WriteLine("入力が空です");
                return;
            }

            if (!File.Exists(wFilePath)) {
                Console.WriteLine("ファイルが存在しません。パスが正しいか確認してください。");
                return;
            }

            using (var wReader = new StreamReader(wFilePath)) {
                string wText = wReader.ReadToEnd();

                List<int> wSubstrings = EnumerateSubstrings(wText);

                if (wSubstrings.Any()) {
                    Console.WriteLine("3文字以上の部分文字列:");
                    foreach (int wSubstring in wSubstrings) {
                        Console.WriteLine(wSubstring);
                    }
                } else {
                    Console.WriteLine("3文字以上の部分文字列が見つかりませんでした。");
                }
            }
        }

        /// <summary>
        /// 三文字以上の数字だけから成る部分文字列を抜き出すメソッド
        /// </summary>
        /// <param name="vText">原文</param>
        /// <returns>三文字以上の数字だけから成る部分文字列</returns>
        static List<int> EnumerateSubstrings(string vText) {

            var wMatches = Regex.Matches(vText, @"\b(\d{3,})\b");
            var wSubstrings = new List<int>();

            foreach (Match wMatch in wMatches) {
                if (int.TryParse(wMatch.Value, out int wNumber)) {
                    wSubstrings.Add(wNumber);
                }
            }

            return wSubstrings;
        }
    }
}
