using System;
using System.Text.RegularExpressions;

namespace Practice10_6_1 {
    //Practice10-6-1 ５文字の回文とマッチする正規表現を書いてください。数字や記号だけからなる回文を除外するにはどうしたら良いのかも考えてください。
    class Program {
        static void Main(string[] args) {
            var wText = "しんぶんし　るすにする しるし　12321 godog ^^:^^ ";
            var wPattern = @"\b(?![\W\d]+)(\w)(\w)\w\2\1\b";
            var wMatches = Regex.Matches(wText, wPattern);
            foreach (Match wMatch in wMatches) {
                Console.WriteLine(wMatch);
            }
        }
    }
}
