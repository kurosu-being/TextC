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

            int wClassCount = File.ReadAllLines(wFilePath, Encoding.UTF8).Count(line => line.Contains("class"));

            Console.WriteLine($"\"class\"キーワードが含まれる行数: {wClassCount}");
        }
    }
}