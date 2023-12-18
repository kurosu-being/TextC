using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Practice9_5_1 {
    //Practice9-5-1 指定したディレクトリおよびそのサブディレクトリの配下にあるファイルからファイルサイズが1Mバイト以上のファイル名の一覧を表示するプログラムを書いてください。
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("ディレクトリおよびサブディレクトリの配下にあるファイルからファイルサイズが1Mバイト以上のファイル名を一覧します。\nパスを入力してください。");
            string wFilePath = Console.ReadLine();

            if (!Directory.Exists(wFilePath)) {
                Console.WriteLine("指定されたディレクトリが見つかりません。パスに間違いがないかご確認ください。");
                return;
            }

            List<string> wLargeFiles = GetFilesLargerOrEqual1M(wFilePath);

            if (wLargeFiles.Count > 0) {
                Console.WriteLine("1MB以上のファイル一覧:");

                foreach (string wFileName in wLargeFiles) {
                    Console.WriteLine(wFileName);
                }
            } else {
                Console.WriteLine("1MB以上のファイルは見つかりませんでした。");
            }
        }

        /// <summary>
        /// 1Mバイトのファイル名
        /// </summary>
        /// <param name="vDirectoryPath">指定されたディレクトリ</param>
        /// <returns>ファイル名</returns>
        static List<string> GetFilesLargerOrEqual1M(string vDirectoryPath) {
            var wLargeFiles = new List<string>();
            var wDirectory = new DirectoryInfo(vDirectoryPath);

            foreach (FileInfo wFile in wDirectory.GetFiles("*", SearchOption.AllDirectories).Where(x => x.Length >= 1024 * 1024)) {
                    wLargeFiles.Add(wFile.Name);
            }
            return wLargeFiles;
        }
    }
}

