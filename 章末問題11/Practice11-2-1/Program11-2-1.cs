using System;
using System.IO;
using System.Xml.Linq;

namespace Practice11_2_1 {
    /*　次のようなXMLファイルがあります。
<?xml version="1.0" encoding="utf-8" ?>
<difficultkanji>
 <word>
  <kanji>鬼灯</kanji>
  <yomi>ほおずき</yomi>
 </word>
 <word>
  <kanji>暖簾</kanji>
  <yomi>のれん</yomi>
 </word>
 <word>
  <kanji>杜撰</kanji>
  <yomi>ずさんく/yomi>
 </word>
 <word>
  <kanji>坩堝</kanji>
  <yomi>るつぼ</yomi>
 </word>
</difficultkanji>
    このXMLファイルを次の形式に変換し、別のファイルに保存してください。k
<?xml version="1.0"　encoding="utf-8" ?>
<difficultkanji>
<word kanji="鬼灯"yomi="ほおずき" />
<word kanji="暖簾"yomi="のれん" />
<word kanji="杜撰"yomi="ずさん" />
<word kanji="坩堝"yomi="るつぼ" />
</difficultkanji>
*/

    namespace Practice11_2_1 {
        class Program {
            static void Main(string[] args) {
                Console.WriteLine("XMLファイルのフォーマットを修正し、同じディレクトリ内の別のファイルに保存します。XMLファイルのパスを入力してください。");
                var wInputFile = Console.ReadLine();
                if (!File.Exists(wInputFile)) {
                    Console.WriteLine("ファイルが存在しません。パスが正しいか確認してください。");
                    return;
                }

                if (Path.GetExtension(wInputFile) != "xml") {
                    Console.WriteLine("XMLファイルではありません。XMLファイルのパスを入力してください.");
                    return;
                }

                // XMLファイルを読み込む
                var wDocument = XDocument.Load(wInputFile);

                foreach (var wOrdElement in wDocument.Descendants("word")) {
                    var wKanjiValue = wOrdElement.Element("kanji")?.Value ?? "";
                    var wYomiValue = wOrdElement.Element("yomi")?.Value ?? "";

                    wOrdElement.RemoveNodes();
                    wOrdElement.SetAttributeValue("kanji", wKanjiValue);
                    wOrdElement.SetAttributeValue("yomi", wYomiValue);
                }

                Console.WriteLine("新しいXMLファイルの名前を入力してください。");

                var wOutputFileName = Console.ReadLine();
                var wOutputFile = Path.Combine(Path.GetDirectoryName(wInputFile), wOutputFileName + ".xml");
                wDocument.Save(wOutputFile);

                Console.WriteLine("新しいファイルが作成されました。");
            }
        }
    }
}