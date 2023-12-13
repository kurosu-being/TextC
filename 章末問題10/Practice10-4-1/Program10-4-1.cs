using System;
using System.Collections.Generic;
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

            if (string.IsNullOrEmpty(wFilePath)) {
                Console.WriteLine("入力が空です");
                return;
            }

            if (!File.Exists(wFilePath)) {
                Console.WriteLine("ファイルが存在しません。パスが正しいか確認してください。");
                return;
            }

            try {
                var wTempFilePath = Path.GetTempFileName();

                IEnumerable<string> wLines = File.ReadLines(wFilePath, Encoding.UTF8)
                    .Select(line => Regex.Replace(line, @"\s*=\s*", "=").ToLower())
                    .Select(line => Regex.Replace(line, @"version=v4.0", "version=v5.0"));

                File.WriteAllLines(wTempFilePath, wLines, Encoding.UTF8);

                File.Delete(wFilePath);
                File.Move(wTempFilePath, wFilePath);

                Console.WriteLine("ファイルが書き換えられました");
            } catch (Exception ex) {
                Console.WriteLine($"エラーが発生しました: {ex.Message}");
            }
        }
    }
}


