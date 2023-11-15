using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Practice9_1_1 {
    /*Practice9-1-1 指定したC#のソースファイルを読み込み、キーワード"class"が含まれている行数をカウントするコンソールアプリケーションCountClassを作成してください。
    このとき、StreamReaderクラスを使い1行ずつ読み込む処理にしてください。なお、以下の2点を前提として構いません。
    ・classキーワードの前後には、必ず空白文字がある
    ・リテラル文字列やコメントの中にはclassという単語は含まれない */
    class Program {
        static void Main() {
            Console.WriteLine("C#のソースファイルのパスを入力してください:");
            string wFilePath = Console.ReadLine();

            if (!File.Exists(wFilePath)) {
                Console.WriteLine("ファイルが見つかりませんでした。");
                return;
            }

            int wClassCount = 0;

            using (var wReader = new StreamReader(wFilePath)) {
                while (!wReader.EndOfStream) {
                    string wLine = wReader.ReadLine();

                    int wCount = File.ReadLines(wFilePath, Encoding.UTF8).Count(x => x.Contains("class"));
                    wClassCount = wCount;
                }
            }

            Console.WriteLine($"\"class\"キーワードが含まれる行数: {wClassCount}");
        }
    }
}
