using System;

namespace Practice1._3_1 {
    class Program {
        //Practice1.3-4 2で生成したインスタンスをPerson型及びobject型の変数に代入できることを確認してください
        static void Main(string[] args) {
            Student wstudent = new Student();
            var name = wstudent.Name;
            var grade = wstudent.Grade;
            var classnumber = wstudent.ClassNumber;
            Console.WriteLine("{name}は、{grade}年{classnumber}組に所属しています");
            Person wperson = wstudent;
            object wobj = wstudent;
        }
    }
}
