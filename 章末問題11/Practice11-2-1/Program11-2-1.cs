using System;
using System.IO;
using System.Xml.Linq;

namespace Practice11_2_1 {
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
