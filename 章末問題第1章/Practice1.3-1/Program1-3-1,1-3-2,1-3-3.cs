using System;

namespace Practice1._3_1 {
    class Program {
        //Practice1.3-1　Pesonクラスを継承し、Studentクラスを定義してください。Studentには2つのプロパティ、Grade（学年）とClassNumber(組)を追加してください。2つのプロパティとも型はintとします。
        //Practice1.3-2　Studentクラスのインスタンスを生成するコードを書いてください。このとき、すべてのプロパティに値を設定してください。
        //Practice1.3-3 2で生成したインスタンスの各プロパティの値をコンソールに出力するコードを書いてください。
        static void Main(string[] args) {
            Student wStudent = new Student("黒子", new DateTime(2000, 2, 2), 3, 10);
            var wName = wStudent.Name;
            var wGrade = wStudent.Grade;
            var wGlassnumber = wStudent.ClassNumber;
            Console.WriteLine($"{wName}は、{wGrade}年{wGlassnumber}組に所属しています");
        }
    }
}
