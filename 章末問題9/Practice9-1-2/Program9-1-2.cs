using System;
using System.IO;
using System.Linq;
using System.Text;


namespace Practice9_1_2 {
    class Program {
        //Practice9-1-2 Practice9-1-1のプログラムをFile.ReadAllLinesメソッドを利用して書き換えてください。
        static void Main() {
            Console.WriteLine("C#のソースファイルのパスを入力してください(CountClass.csはチケットに貼っています)");
            string wFilePath = Console.ReadLine();

            if (!File.Exists(wFilePath)) {
                Console.WriteLine("ファイルが見つかりませんでした。");
                return;
            }

            int wClassCount = File.ReadAllLines(wFilePath, Encoding.UTF8).Count(x => x.Contains("class"));

            Console.WriteLine($"\"class\"キーワードが含まれる行数: {wClassCount}");
        }
    }
}