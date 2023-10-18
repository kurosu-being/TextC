using System;

namespace 演習問題第1章問3_4 {
    class Program {
        //Practice1.3-4 2で生成したインスタンスをPerson型及びobject型の変数に代入できることを確認してください
        static void Main(string[] args) {
            Student wStudent = new Student("黒子", new DateTime(2000, 2, 2), 3, 10);
            Console.WriteLine($"{wStudent.Name}は、{wStudent.Grade}年{wStudent.ClassNumber}組に所属しています");
            //Practice1.3-4 2で生成したインスタンスをPerson型及びobject型の変数に代入
            Person wPerson = wStudent;
            object wObj = wStudent;
        }
    }
}