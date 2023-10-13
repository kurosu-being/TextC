using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1._3_1 {
    class Program {
        //Practice1.3-1　Pesonクラスを継承し、Studentクラスを定義してください。Studentには2つのプロパティ、Grade（学年）とClassNumber(組)を追加してください。2つのプロパティとも型はintとします。
        //Practice1.3-2　Studentクラスのインスタンスを生成するコードを書いてください。このとき、すべてのプロパティに値を設定してください。
        //Practice1.3-3 2で生成したインスタンスの各プロパティの値をコンソールに出力するコードを書いてください。
        static void Main(string[] args) {
            Student student = new Student{
                Name = "黒子", Birthday = new DateTime(2000, 2, 2),Grade = 3, ClassNumber = 10,
            };
            Console.WriteLine("{0}は、{1}年{2}組に所属しています",student.Name, student.Grade, student.ClassNumber);
        }
    }
}
