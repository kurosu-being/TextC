﻿using System;

namespace 演習問題第1章問3_1_3_2_3_3 {
    class Program {
        //Practice1.3-1　Pesonクラスを継承し、Studentクラスを定義してください。Studentには2つのプロパティ、Grade（学年）とClassNumber(組)を追加してください。2つのプロパティとも型はintとします。
        //Practice1.3-2　Studentクラスのインスタンスを生成するコードを書いてください。このとき、すべてのプロパティに値を設定してください。
        //Practice1.3-3 2で生成したインスタンスの各プロパティの値をコンソールに出力するコードを書いてください。
        static void Main(string[] args) {
            Student wStudent = new Student("黒子", new DateTime(2000, 2, 2), 3, 10);
            Console.WriteLine($"{wStudent.Name}は、{wStudent.Grade}年{wStudent.ClassNumber}組に所属しています");
        }
    }
}
