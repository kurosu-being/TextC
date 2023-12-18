using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Practice10_4_1 {
    //Practice10-4-1 テキストファイルを読み込み、version="v4.0"と書かれた箇所を、version="v5.0"に置き換え、同じファイルに保存して下ください。
    //なお、入力ファイルの=の前後には任意の数の空白文字が入っていることもあります。出力時には、=の前後の空白は削除してください。"version"は"Version"である可能性もあります。
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("ファイルのパスを入力してください。version=\"v4.0\"と書かれた箇所を、version=\"v5.0\"に置き換え、同じファイルに保存します。");
            var wFilePath = Console.ReadLine();

            if (string.IsNullOrEmpty(wFilePath)) {
                Console.WriteLine("入力が空です");
                return;
            }

            if (!File.Exists(wFilePath)) {
                Console.WriteLine("ファイルが存在しません。正しいパスを入力してください。");
                return;
            }

            try {
                var wLines = File.ReadAllLines(wFilePath, Encoding.UTF8);
                var wNewLines = new string[wLines.Length];
                bool wWasReplaced = false;

                for (int i = 0; i < wLines.Length; i++) {
                    string wModifiedLine = Regex.Replace(wLines[i], @"version\s*=\s*""v4\.0""", "version=\"v5.0\"", RegexOptions.IgnoreCase);
                    wModifiedLine = Regex.Replace(wModifiedLine, @"\s*=\s*", "=");
                    wNewLines[i] = wModifiedLine;
                    if (wModifiedLine.Contains("version=\"v5.0\"")) {
                        wWasReplaced = true;
                    }
                }
                if (!wWasReplaced) {
                    Console.WriteLine("置換する文字列が見つかりませんでした");
                    return;
                }

                File.WriteAllLines(wFilePath, wNewLines, Encoding.UTF8);
                Console.WriteLine("ファイルが書き換えられました。");

            } catch (UnauthorizedAccessException ex) {
                Console.WriteLine($"アクセス権限がありません: {ex.Message}");
            } catch (IOException ex) {
                Console.WriteLine($"I/O エラーが発生しました: {ex.Message}");
            } catch (Exception ex) {
                Console.WriteLine($"エラーが発生しました: {ex.Message}");
            }
        }
    }
}

