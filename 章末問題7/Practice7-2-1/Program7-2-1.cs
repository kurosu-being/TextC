using System;

namespace Practice7_2_1 {
    /*「7.3ディクショナリを使ったサンプルプログラム」で作成したプログラムに、以下の機能を追加してください。*/
    //Practice7-2-1 ディクショナリに登録されている用語の数を示すCountプロパティをAbbreviationsクラスに追加してください。
    class Program {
        static void Main(string[] args) {
            Abbreviations wAbbreviations = new Abbreviations();

            // いくつかの要素を追加
            wAbbreviations.Add("MK", "Maki Kurosu");
            wAbbreviations.Add("HAS", "Hatta Ami San");
            wAbbreviations.Add("", "Graphics Processing Unit");

            // 現在の要素数を取得
            int wCount = wAbbreviations.Count;
            Console.WriteLine($"要素の数: {wCount}");

            // 要素を削除
            bool wRemoved = wAbbreviations.Remove("CPU");
            Console.WriteLine($"CPU を削除: {wRemoved}");

            // 削除後の要素数を取得
            wCount = wAbbreviations.Count;
            Console.WriteLine($"削除後の要素の数: {wCount}");

            Console.WriteLine("省略形が３文字のものを表示します");
            wAbbreviations.DisplayThree();
        }
    }
}
