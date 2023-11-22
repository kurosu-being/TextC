using System;
using System.IO;
using System.Linq;

namespace Practice7_2_3 {
    //Practice7-2-3 CountプロパティとRemoveメソッドを利用するコードを書いてください。
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Abbreviations.txtのパスを入力してください(Abbreviations.txtはチケットに貼っています)");
            string wFilePath = Console.ReadLine();

            if (!File.Exists(wFilePath)) {
                Console.WriteLine("存在しないパスです");
                return;
            }

            var wLines = File.ReadAllLines(wFilePath);
            var wDict = wLines.Select(x => x.Split('=')).ToDictionary(x => x[0], x => x[1]);

            var wAbbreviations = new Abbreviations(wDict);

            //いくつかの要素を追加
            wAbbreviations.Add("KM", "黒子 真紀");
            wAbbreviations.Add("HAS", "八太 亜美 さん");
            wAbbreviations.Add("MKS", "宮原 啓樹 さん");

            //現在の要素数を取得
            int wCount = wAbbreviations.Count;
            Console.WriteLine($"要素の数: {wCount}");

            //要素を削除
            bool wRemoved = wAbbreviations.Remove("KM");
            Console.WriteLine($"KM を削除: {wRemoved}");

            //削除後の要素数を取得
            wCount = wAbbreviations.Count;
            Console.WriteLine($"削除後の要素の数: {wCount}");
        }
    }
}

