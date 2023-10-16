using System;

namespace Practice1._3_1 {
    class Program {
        //Practice1.3-4 2で生成したインスタンスをPerson型及びobject型の変数に代入できることを確認してください
        static void Main(string[] args) {
            Student wStudent = new Student();
            var name = wStudent.Name;
            var grade = wStudent.Grade;
            var classnumber = wStudent.ClassNumber;
            Console.WriteLine("{name}は、{grade}年{classnumber}組に所属しています");
            Person wPerson = wStudent;
            object wObj = wStudent;
        }
    }
}
