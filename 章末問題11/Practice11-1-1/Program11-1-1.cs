using System;
using System.IO;
using System.Xml.Linq;

namespace Practice11_1_1 {
    /*次のXMLファイルがありまます。このXMLファイルを用いてコードを書いてください。
    <?xml version="1.0" encoding="utf-8" ?>
<ballSports>
　<ballsport>
　　<name kanji="籠球">バスケットボール</name>
　　<teammembers>5</teammembers>
　　<firstplayed>1891</firstplayed>
　</ballsport>
　<ballsport>
　　<name kanji="排球">バレーボール</name>
　　<teammembers>6</teammembers>
　　<firstplayed>1895</firstplayed>
　</ballsport>
　<ballsport>
　　<name kanji="野球">ベースボール</name>
　　<teammembers>9</teammembers>
　　<firstplayed>1846</firstplayed>
　</ballsport>
</ballSports> */
    //Practice11-1-1 XMLファイルを読み込み、競技名とチームメンバーの数の一覧を表示してください。
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("XMLファイルを読み込み、競技名とチームメンバーの数の一覧を表示します。XMLファイルのパスを入力してください。");
            var wInputFile = Console.ReadLine();
            if (!File.Exists(wInputFile)) {
                Console.WriteLine("ファイルが存在しません。パスが正しいか確認してください。");
                return;
            }

            foreach (XElement wGame in XDocument.Load(wInputFile).Root.Elements()) {
                Console.WriteLine($"競技名「{wGame.Element("name").Value}」 チームメンバー:{wGame.Element("teammembers").Value}");
            }
        }
    }
}
