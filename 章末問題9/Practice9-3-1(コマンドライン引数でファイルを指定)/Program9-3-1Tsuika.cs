using System;
using System.IO;
using System.Text;

namespace Practice9_3_1_コマンドライン引数でファイルを指定_ {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("1つ目のテキストファイルの末尾に、2つ目のテキストファイル内容を追加します。コマンドライン引数で指定してください。");

            if (args.Length != 2) {
                Console.WriteLine("引数が正しくありません。プログラムを終了します。");
                return;
            }

            if (args.Length == 0) {
                Console.WriteLine($"コマンドラインで引数を指定してください。書き方は{Environment.NewLine}MyProgram.exe arg1 arg2{Environment.NewLine}というようにします。");
                return;
            }

            var wSourceFilePath = args[0]; 
            var wAddFilePath = args[1];   

            if (!File.Exists(wSourceFilePath)) {
                Console.WriteLine("1つ目のファイルが見つかりません。パスに間違いがないかご確認ください。");
                return;
            }

            if (!File.Exists(wAddFilePath)) {
                Console.WriteLine("2つ目のファイルが見つかりません。パスに間違いがないかご確認ください。");
                return;
            }

            if (wSourceFilePath == wAddFilePath) {
                Console.WriteLine("最初に指定されたテキストファイルと同じです。別のテキストファイルを指定してください。");
                return;
            }

            using (var wStreamReader = new StreamReader(wAddFilePath, Encoding.UTF8)) {
                using (StreamWriter wStreamWriter = File.AppendText(wSourceFilePath)) {
                    string wLine;
                    while ((wLine = wStreamReader.ReadLine()) != null) {
                        wStreamWriter.WriteLine(wLine);
                    }
                }
            }

            Console.WriteLine("ファイルの内容を追記しました。");
        }
    }
}
