using System;
using System.IO;
using System.Linq;
using System.Text;


namespace Practice9_1_2 {
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
                    int wCount = File.ReadAllLines(wFilePath, Encoding.UTF8).Count(x => x.Contains("class"));
                    wClassCount = wCount;
                }
            }

            Console.WriteLine($"\"class\"キーワードが含まれる行数: {wClassCount}");
        }
    }
}