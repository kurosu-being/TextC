using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Practice11_1_2 {
    //Practice11-1-2 最初にプレーされた年の若い順に漢字の表記名を表示してください。
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("最初にプレーされた年の若い順に漢字の表記名を表示します。XMLファイルのパスを入力してください。");
            var wInputFile = Console.ReadLine();
            if (!File.Exists(wInputFile)) {
                Console.WriteLine("ファイルが存在しません。パスが正しいか確認してください。");
                return;
            }

            var wXdocument = XDocument.Load(wInputFile);
            foreach (var wGame in wXdocument.Root.Elements().OrderBy(x => (int)x.Element("firstplayed"))) {
                var wXname = wGame.Element("name");
                XAttribute wXAttribute = wXname.Attribute("kanji");

                if (string.IsNullOrEmpty(wXAttribute.Value)) {
                    Console.WriteLine($"漢字表記名なし");
                } else {
                    Console.WriteLine($"漢字表記名「{wXAttribute.Value}」");
                }
            }
        }
    }
}
