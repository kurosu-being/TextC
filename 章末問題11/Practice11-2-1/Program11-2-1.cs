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
    このXMLファイルを次の形式に変換し、別のファイルに保存してください。
<?xml version="1.0"　encoding="utf-8" ?>
<difficultkanji>
<word kanji="鬼灯"yomi="ほおずき1>
<word kanji="暖簾"yomi="のれん"1>
<word kanji="杜撰"yomi="ずさん"1>
<word kanji="坩堝"yomi="るつぼ!>
</difficultkanji>
*/
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("XMLファイルのパスを入力してください。");
            var wInputFile = Console.ReadLine();
            if (!File.Exists(wInputFile)) {
                Console.WriteLine("ファイルが存在しません。パスが正しいか確認してください。");
                return;
            }

            
            
        }
    }
}
