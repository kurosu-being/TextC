using System;
using System.IO;

namespace Practice9_3_1 {
    //Practice9-3-1あるテキストファイルの最後に別のテキストファイルの内容を追加するコンソールアプリケーションを書いてください。コマンドラインで2つのテキストファイルのパス名を指定できるようにしてください。
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("1つ目のテキストファイルの最後に、2つ目のテキストファイルの内容を追加します。\n1つ目のファイルパス,2つ目のファイルパスという書き方で指定してください");
            string wFilePath = Console.ReadLine();

            if (wFilePath.Split(',').Length != 2) {
                Console.WriteLine("正しい数のパスが提供されていません。最初の引数に元のファイル、次の引数に追記先のファイルを指定してください。");
                return;
            }

            string wSouceFilePath = wFilePath.Split(',')[0];
            string wAnotherFilePath = wFilePath.Split(',')[1];
            if (!File.Exists(wSouceFilePath) || !File.Exists(wAnotherFilePath)) {
                Console.WriteLine("指定されたファイルが見つかりません。パスに間違いがないかご確認ください。");
                return;
            }

            string[] wSourceFileLines = File.ReadAllLines(wSouceFilePath);

            using (StreamWriter wStreamWriter = File.AppendText(wAnotherFilePath)) {
                foreach (string wLine in wSourceFileLines) {
                    wStreamWriter.WriteLine(wLine);
                }
            }

            Console.WriteLine("ファイルの内容を追記しました。");
        }
    }
}
