using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Practice10_1_1 {
    //Practice10-1-1 指定された文字列が電話番号かどうか判定するメソッドを定義してください。電話番号は必ずハイフン(-)で区切られていなければなりません。また、先頭三文字は"090","080","070"のいずれかとします。
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("電話番号を含む文字列を半角で入力してください。");
            var wInput = Console.ReadLine();
            var wMessage = JudgePhoneNumber(wInput) ? "電話番号です" : "電話番号ではありません";
            Console.WriteLine(wMessage);
        }
        static bool JudgePhoneNumber(string vInput) {
            string wPattern = @"^(090|080|070)-\d{4}-\d{4}$";

            return Regex.IsMatch(vInput, wPattern);
        }
    }
}
