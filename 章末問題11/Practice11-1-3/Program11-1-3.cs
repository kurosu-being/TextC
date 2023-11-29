using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Practice11_1_3 {
    //Practice11-1-3 メンバー人数が最も多い競技名を表示してください。
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("XMLファイルのパスを入力してください。");
            var wInputFile = Console.ReadLine();
            if (!File.Exists(wInputFile)) {
                Console.WriteLine("ファイルが存在しません。パスが正しいか確認してください。");
            }

            var wXdocument = XDocument.Load(wInputFile);
            var wMaxMembersSport = wXdocument.Root.Elements()
                            .Where(x => (int)x.Element("teammembers") == wXdocument.Root.Elements().Max(y => (int)y.Element("teammembers")))
                            .Select(x => x.Element("name")?.Attribute("kanji")?.Value)
                            .FirstOrDefault();

            if (wMaxMembersSport != null) {
                Console.WriteLine($"メンバー人数が最も多い競技名は「{wMaxMembersSport}」です。");
            } else {
                Console.WriteLine("競技名が見つかりませんでした。");
            }
        }
    }

}
