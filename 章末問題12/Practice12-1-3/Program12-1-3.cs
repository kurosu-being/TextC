﻿using Practice12_1_1;
using System;
using System.Runtime.Serialization;
using System.Xml;

namespace Practice12_1_3 {
    //Practice12-1-3 2で作成したファイルを読み込み、逆シリアル化してください。
    class Program {
        static void Main(string[] args) {
            using (var wReader = XmlReader.Create("employees.xml")) {
                var wSerializer = new DataContractSerializer(typeof(Employee[]));
                Employee[] wEmployees = wSerializer.ReadObject(wReader) as Employee[];
                foreach (var wEmployee in wEmployees) {
                    Console.WriteLine(wEmployee);
                }
            }
        }
    }
}
