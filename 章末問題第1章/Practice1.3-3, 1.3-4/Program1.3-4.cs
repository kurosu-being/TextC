using System;

namespace Practice1._3_1 {
    class Program {
        //Practice1.3-4 2で生成したインスタンスをPerson型及びobject型の変数に代入できることを確認してください
        static void Main(string[] args) {
            Student wstudent = new Student {
                Name = "黒子", Birthday = new DateTime(2000, 2, 2), Grade = 3, ClassNumber = 10,
            };
            Console.WriteLine("{0}は、{1}年{2}組に所属しています", wstudent.Name, wstudent.Grade, wstudent.ClassNumber);

            Person G_person = wstudent;
            object G_obj = wstudent;
        }
    }
}
