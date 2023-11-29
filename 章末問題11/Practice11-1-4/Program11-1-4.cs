using System;
using System.IO;
using System.Xml.Linq;

namespace Practice11_1_4 {
    //Pactice11-1-4 サッカーの情報を追加して、新たなXMLファイルを作成してください。ファイル名は特に問いません。なお、サッカーの情報はご自身で調べてください。
    //手間を惜しまずに調べることもプログラマーには必要なことです。
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("XMLファイルのパスを入力してください。");
            var wInputFile = Console.ReadLine();
            if (!File.Exists(wInputFile)) {
                Console.WriteLine("ファイルが存在しません。パスが正しいか確認してください。");
            }

            var wXdocuments = XDocument.Load(wInputFile);
            var wElement = new XElement("ballsport",
                           new XElement("name", "サッカー"),new XAttribute("kanji", "蹴球"),
                           new XElement("teammembers", "11"),
                           new XElement("firstplayed", "1873"));

            wXdocuments.Root.Add(wElement);
            wXdocuments.Save(wInputFile);

            Console.WriteLine("新しいXMLファイルが作成されました。");
        }
    }
}
