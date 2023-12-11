using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Practice12_2_2 {
    //Practice12-2-2 12-2-1でのNovelistオブジェクトの内容を以下のようなJSONファイルにシリアル化するコードを書いて下さい。
    /*
    {"birth":"1917-12-16T00:00:00Z",
    "masterpieces":["2021年宇宙の旅","幼年期の終り"],
    "name":"アーサー・クラーク"
    */
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Practice12-2-1で逆シリアル化したNovelistオブジェクトをJSONにシリアル化します。");
            Console.WriteLine("XMLファイルパスを入力してください:");
            string wFilePath = Console.ReadLine();

            if (!File.Exists(wFilePath)) {
                Console.WriteLine("ファイルが見つかりません。ファイルパスが正しいか確認してください。");
                return;
            }

            Novelist wNovelist = DeserializeNovelistFromXml(wFilePath);

            if (wNovelist != null) {
                string wJson = SerializeNovelistToJson(wNovelist);
                string wJsonFilePath = Path.ChangeExtension(wFilePath, ".json");
                File.WriteAllText(wJsonFilePath, wJson);
                Console.WriteLine($"JSONファイルが作成されました: {wJsonFilePath}");
            }

        }

        static Novelist DeserializeNovelistFromXml(string vFilePath) {
            using (var wReader = new StreamReader(vFilePath)) {
                var wSerializer = new XmlSerializer(typeof(Novelist));
                return wSerializer.Deserialize(wReader) as Novelist;
            }
        }

        static string SerializeNovelistToJson(Novelist vNovelist) {
            var wSettings = new JsonSerializerSettings {
                
            };
            
            return JsonConvert.SerializeObject(vNovelist, Newtonsoft.Json.Formatting.Indented, wSettings);
        }
    }
}
