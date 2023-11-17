using System;
using System.Collections.Generic;
using System.IO;

namespace Practice9_5_1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("ディレクトリおよびサブディレクトリの配下にあるファイルからファイルサイズが1Mバイトのファイル名を一覧します。\nパスを入力してください。");
            string wFilePath = Console.ReadLine();

            List<string> wLargeFiles = GetLargeFiles(wFilePath);

            if (wLargeFiles.Count > 0) {
                Console.WriteLine("1MB以上のファイル一覧:");

                foreach (string wFileName in wLargeFiles) {
                    Console.WriteLine(wFileName);
                }
            } else {
                Console.WriteLine("1MB以上のファイルは見つかりませんでした。");
            }
        }

        static List<string> GetLargeFiles(string directoryPath) {
            var wLargeFiles = new List<string>();

            try {
                var wDirectory = new DirectoryInfo(directoryPath);

                FileInfo[] wFiles = wDirectory.GetFiles("*", SearchOption.AllDirectories);

                foreach (FileInfo wFile in wFiles) {
                    if (wFile.Length >= 1024 * 1024) 
                    {
                        wLargeFiles.Add(wFile.FullName);
                    }
                }
            } catch (Exception wEx) {
                Console.WriteLine($"エラーが発生しました: {wEx.Message}");
            }

            return wLargeFiles;
        }

    }
}

