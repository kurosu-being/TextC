using Practice12_1_1;
using System;
using System.Runtime.Serialization;
using System.Xml;

namespace Practice12_1_2 {
    //Practice12-1-2 複数のEmployyeeオブジェクトが配列に格納されているとします。この配列をDataContractSerializerクラスを使ってXMLファイルにシリアル化してください。
    class Program {
        static void Main(string[] args) {
            var wEmployees = new Employee[] {
                new Employee(953, "K", new DateTime(2023, 4, 1)),
                new Employee(903, "L", new DateTime(2023, 4, 2)),
                new Employee(999, "M", new DateTime(2023, 4, 3))
            };

            using (var wWriter = XmlWriter.Create("employees.xml")) {
                var wSerializer = new DataContractSerializer(wEmployees.GetType());
                wSerializer.WriteObject(wWriter, wEmployees);
            }
            Console.WriteLine("Employeeクラスのオブジェクトをシリアライズしました。");
        }
    }
}
