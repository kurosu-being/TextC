using System;

namespace Practice1._3_1 {
    class Program {
        //Practice1.3-4 2で生成したインスタンスをPerson型及びobject型の変数に代入できることを確認してください
        static void Main(string[] args) {
            Student wStudent = new Student("黒子", new DateTime(2000, 2, 2), 3, 10);
            var vName = wStudent.Name;
            var vGrade = wStudent.Grade;
            var vClassnumber = wStudent.ClassNumber;
            Console.WriteLine($"{vName}は、{vGrade}年{vClassnumber}組に所属しています");
            //Practice1.3-4 2で生成したインスタンスをPerson型及びobject型の変数に代入
            Person wPerson = wStudent;
            object wObj = wStudent;
        }
    }
}
