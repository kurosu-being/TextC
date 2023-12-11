using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Practice9_1_3 {
    //Practice9-1-3 Practice9-1-1のプログラムをFile.ReadlLinesメソッドを利用して書き換えてください。
    class Program {
        static void Main() {
            Console.WriteLine("C#のソースファイルのパスを入力してください(CountClass.csはチケットに貼っています)");
            string wFilePath = Console.ReadLine();

            if (!File.Exists(wFilePath)) {
                Console.WriteLine("ファイルが見つかりませんでした。");
                return;
            }

            var wCount = File.ReadLines(wFilePath, Encoding.UTF8).Count(x => x.Contains(" class "));
            Console.WriteLine($"\"class\"キーワードが含まれる行数: {wCount}");
        }
    }
}