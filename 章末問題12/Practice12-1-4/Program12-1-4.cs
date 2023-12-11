using System;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Practice12_1_4 {
    //Practice12-1-4 複数のEmployeeオブジェクトが配列に格納されているとします。この配列をDataConstractJosonSerializerを使ってJSONファイルに出力してください。この時シリアル化対象にはIdを含めないでください。
    class Program {
        static void Main(string[] args) {
            var wEmployees = new Employee[] {
                new Employee { ID = 953, Name = "K", HireDate = new DateTime(2023, 4, 1)  },
                new Employee { ID = 903, Name = "L", HireDate = new DateTime(2023, 4, 2)  },
                new Employee { ID = 999, Name = "M", HireDate = new DateTime(2023, 4, 3)  }
            };

            Console.WriteLine("EmployeeクラスのオブジェクトをJSONファイルにシリアライズします。保存先のディレクトリを指定してください");
            string wDirectoryPath = Console.ReadLine();
            string wFilePath = Path.Combine(wDirectoryPath, "employee.json");

            using (var wFileStream = new FileStream(wFilePath, FileMode.Create, FileAccess.Write)) {
                var wSerializer = new DataContractJsonSerializer(wEmployees.GetType());
                wSerializer.WriteObject(wFileStream, wEmployees);
            }

            Console.WriteLine("EmployeeクラスのオブジェクトをJSONファイルにシリアライズしました。");
        }
    }
}
