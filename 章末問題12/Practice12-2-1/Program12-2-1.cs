using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Practice12_2_1 {
    class Program {
        //Practice12-2-1 XmlSerializerクラスw使って以下のXMLファイルを逆シリアル化し、Novelistオブジェクトを作製して下さい。Novelistクラスには、必要ならば適切な属性を付加して下さい。
        /*@"<?xml version=""1.0"" encoding=""utf-8"" ?>
                         <novelist>
                             <name>アーサー・C・クラーク</name>
                             <birth>1917-12-16</birth>
                             <masterpieces>
                                 <title>2001年宇宙の旅</title>
                                 <title>幼年期終り</title>
                             </masterpieces>
                         </novelist>"
                         */
        static void Main() {
            Console.WriteLine("XMLファイルを逆シリアル化します。ファイルパスを入力してください");
            string wFilePath = Console.ReadLine();

            if (!File.Exists(wFilePath)) {
                Console.WriteLine("ファイルが見つかりません。ファイルパスが正しいか確認してください。");
                return;
            }

            using (var wReader = XmlReader.Create(wFilePath)) {
                var wSerializer = new XmlSerializer(typeof(Novelist));
                var wNovelist = wSerializer.Deserialize(wReader) as Novelist;

                Console.WriteLine($"作家名: {wNovelist.Name}");
                Console.WriteLine($"生年月日: {wNovelist.Birth.ToShortDateString()}");

                foreach (var wMasterpiece in wNovelist.Masterpieces) {
                    Console.WriteLine("代表作: " + wMasterpiece);
                }
            }
        }
    }
}


