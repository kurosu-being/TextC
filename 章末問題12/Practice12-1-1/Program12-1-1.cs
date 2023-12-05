using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Practice12_1_1 {
    /*Practice12-1-1 以下のEmployeeクラスが定義されています。このオブジェクトをXMLにシリアル化するコードと逆シリアル化するコードを、Xml Serializerクラスを使って書いてください。
    この時、XMLの要素数(タグ名)はすべて小文字にしてください。*/
    class Program {
        static void Main(string[] args) {
            var wEmployeeK = new Employee { ID = 953, Name = "K", HireDate = new DateTime(2023, 4, 1) };

            Console.WriteLine("EmployeeクラスのオブジェクトをXMLにシリアライズします。保存先のディレクトリを指定してください");
            string wDirectoryPath = Console.ReadLine();
            string wFilePath = Path.Combine(wDirectoryPath, "employee.xml");

            using (var wWriter = XmlWriter.Create(wFilePath)) {
                var wSerializer = new XmlSerializer(typeof(Employee));
                wSerializer.Serialize(wWriter, wEmployeeK);
            }

            Console.WriteLine("ファイルを出力しました。以下は逆シリアル化した結果です。");

            using (var wReader = XmlReader.Create("employee.xml")) {
                var wSerializer = new XmlSerializer(typeof(Employee));
                var wEmployee = wSerializer.Deserialize(wReader) as Employee;
                Console.WriteLine(wEmployee);
            }
        }
    }
}
