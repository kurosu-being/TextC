using System;
using System.IO;

namespace Practice7_2_4 {
    //Practice7-2-4 3文字の省略語だけを取り出し、以下の形式でコンソールに出力するコードを書いてください。必要ならAbbreviationsクラスに新たなメソッドを追加してください。
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Abbreviations.txtのパスを入力してください(Abbreviations.txtはチケットに貼っています)");
            string wFilePath = Console.ReadLine();
            if (File.Exists(wFilePath)) {
                var wAbbreviations = new Abbreviations(wFilePath);

                //3文字の省略語を取り出し表示
                Console.WriteLine("省略形が３文字のものを表示します");
                wAbbreviations.DisplayThree();
            } else {
                Console.WriteLine("存在しないパスです");
            }
        }
    }
}

