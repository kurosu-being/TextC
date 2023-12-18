using System;
using System.IO;
using System.Text;

namespace Practice9_3_1 {
    //Practice9-3-1あるテキストファイルの最後に別のテキストファイルの内容を追加するコンソールアプリケーションを書いてください。コマンドラインで2つのテキストファイルのパス名を指定できるようにしてください。
    class Program {
        static void Main(string[] args) {
            Console.WriteLine($"1つ目のテキストファイルの末尾に、2つ目のテキストファイル内容を追加します。{Environment.NewLine}まず追加先のテキストファイルのパスを入力してください");
            string wSourceFilePath = Console.ReadLine();

            if (!File.Exists(wSourceFilePath)) {
                Console.WriteLine("指定されたファイルが見つかりません。パスに間違いがないかご確認ください。");
                return;
            }

            Console.WriteLine("次に追加したいテキストファイルのパスを入力して下さい。");
            string wAddFilePath = Console.ReadLine();

            if (!File.Exists(wAddFilePath)) {
                Console.WriteLine("指定されたファイルが見つかりません。パスに間違いがないかご確認ください。");
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
