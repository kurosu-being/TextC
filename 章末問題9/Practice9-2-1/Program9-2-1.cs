using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9_2_1 {
    /*Practice9-2-1 テキストファイルを読み込み、行の先頭に行番号を振り、その結果を別のテキストファイルに出力するプログラムを書いてください。書式と出力先のファイル名は自由に決めてかまいません。
    　出力するファイル名と同盟のファイルがあった場合は、上書きしてください。*/
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("パスを入力してください(いろは歌.txtはチケットに貼っています)");
            string wFilePath = Console.ReadLine();

            var wFileInfo = new FileInfo(wFilePath);
            if (!wFileInfo.Exists) {
                Console.WriteLine("ファイルが見つかりませんでした。");
                return;
            }

            string wInputFileName = wFilePath;
            string wOutputFileName = "output.txt";

            using (var wStreamWriter = new StreamWriter(wOutputFileName)) {
                string[] wLines = File.ReadAllLines(wInputFileName);
                for (int i = 0; i < wLines.Length; i++) {
                            wStreamWriter.WriteLine($"{i + 1}: {wLines[i]}");
                        }
                    }

                    Console.WriteLine("ファイルの書き込みが完了しました。");
                }
            }
        }
