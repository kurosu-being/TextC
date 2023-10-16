using System;

namespace Practice1._3_1 {
    class Program {
        //Practice1.3-1　Pesonクラスを継承し、Studentクラスを定義してください。Studentには2つのプロパティ、Grade（学年）とClassNumber(組)を追加してください。2つのプロパティとも型はintとします。
        //Practice1.3-2　Studentクラスのインスタンスを生成するコードを書いてください。このとき、すべてのプロパティに値を設定してください。
        //Practice1.3-3 2で生成したインスタンスの各プロパティの値をコンソールに出力するコードを書いてください。
        static void Main(string[] args) {
            Student wStudent = new Student();
            Console.WriteLine("{0}は、{1}年{2}組に所属しています", wStudent.Name, wStudent.Grade, wStudent.ClassNumber);
        }
    }
}
