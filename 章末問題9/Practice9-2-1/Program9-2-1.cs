using System;
using System.IO;
using System.Text;

namespace Practice9_2_1 {
    /*Practice9-2-1 テキストファイルを読み込み、行の先頭に行番号を振り、その結果を別のテキストファイルに出力するプログラムを書いてください。書式と出力先のファイル名は自由に決めてかまいません。
    　出力するファイル名と同名のファイルがあった場合は、上書きしてください。*/
    class Program {
        static void Main(string[] args) {
            Console.WriteLine($"テキストファイル「いろは歌.txt」を読み込み、行の先頭に行番号を振り、その結果をoutput.txtとして別のテキストファイルに出力します。{Environment.NewLine}パスを入力してください(いろは歌.txtはチケットに貼っています)");
            string wFilePath = Console.ReadLine();

            if (!File.Exists(wFilePath)) {
                Console.WriteLine("ファイルが見つかりませんでした。");
                return;
            }

            Console.WriteLine("次に保存先のディレクトリを指定してください");
            string wOutputDirectory = Console.ReadLine();
            if (!Directory.Exists(wOutputDirectory)) {
                Console.WriteLine("指定されたディレクトリが見つかりません。パスに間違いがないかご確認ください。");
                return;
            }

            string wOutputFileName = "output.txt";
            string wOutputFilePath = Path.Combine(wOutputDirectory, wOutputFileName);

            using (var wStreamReader = new StreamReader(wFilePath, Encoding.UTF8)) {
                using (var wStreamWriter = new StreamWriter(wOutputFilePath, false, Encoding.UTF8)) {
                    int wLineNumber = 1;
                    string wLine;
                    while ((wLine = wStreamReader.ReadLine()) != null) {
                        wStreamWriter.WriteLine($"{wLineNumber}: {wLine}");
                        wLineNumber++;
                    }
                }
            }
            Console.WriteLine("ファイルが出力されました。");
        }
    }
}
