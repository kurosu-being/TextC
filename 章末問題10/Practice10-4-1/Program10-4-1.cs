using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Practice10_4_1 {
    //Practice10-4-1 テキストファイルを読み込み、version="v4.0"と書かれた箇所を、version="v5.0"に置き換え、同じファイルに保存して下ください。
    //なお、入力ファイルの=の前後には任意の数の空白文字が入っていることもあります。出力時には、=の前後の空白は削除してください。"version"は"Version"である可能性もあります。
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("version.txtを読み込んでください。version=\"v4.0\"と書かれた箇所を、version=\"v5.0\"に置き換えます。\nファイルのパスを入力してください。(version.txtはチケットに貼ってあります）");
            var wFilePath = Console.ReadLine();
            if (!File.Exists(wFilePath)) {
                Console.WriteLine("ファイルが存在しません。パスが正しいか確認してください");
            }
            if (string.IsNullOrEmpty(wFilePath)) {
                Console.WriteLine("パスが空です");
            }

            string[] wLines = File.ReadAllLines(wFilePath, Encoding.UTF8);
            //マッチングするパターン
            var wPattern = @"\s*=\s*";
            var wReplaseds = wLines.Select(x => Regex.Replace(x, wPattern, "=").ToLower());
            var wPattern2 = @"version=v4.0"; 
            var wReplased2s = wReplaseds.Select(x => Regex.Replace(x, wPattern2, "version=v5.0"));
            foreach (var wReplace in wReplased2s) {
                File.WriteAllLines(wFilePath, wReplased2s);
            }
            Console.WriteLine("ファイルが書き換えられました");
        }
    }
}


