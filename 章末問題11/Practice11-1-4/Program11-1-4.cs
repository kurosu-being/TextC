using System;
using System.IO;
using System.Xml.Linq;

namespace Practice11_1_4 {
    //Pactice11-1-4 サッカーの情報を追加して、新たなXMLファイルを作成してください。ファイル名は特に問いません。なお、サッカーの情報はご自身で調べてください。
    //手間を惜しまずに調べることもプログラマーには必要なことです。
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("同じディレクトリにサッカーの情報を追加して、新たなXMLファイルを作成します。XMLファイルのパスを入力してください。");
            var wInputFile = Console.ReadLine();
            if (!File.Exists(wInputFile)) {
                Console.WriteLine("ファイルが存在しません。パスが正しいか確認してください。");
                return;
            }

            var wXdocuments = XDocument.Load(wInputFile);
            var wOption = new XElement("ballsport");
            var wName = new XElement("name", "サッカー");
            wName.SetAttributeValue("kanji", "蹴球");

            wOption.Add(wName);
            wOption.SetElementValue("teammembers", "11");
            wOption.SetElementValue("firstplayed", "1873");
            var wRoot = new XElement("ballSports", wOption);

            wXdocuments.Root.Add(wRoot);

            Console.WriteLine("新しいXMLファイルの名前を入力してください。");

            var wOutputFileName = Console.ReadLine();


            var wOutputFile = Path.Combine(Path.GetDirectoryName(wInputFile), wOutputFileName + ".xml");

            wXdocuments.Save(wOutputFile);

            Console.WriteLine("新しいXMLファイルが作成されました。");
        }
    }
}

