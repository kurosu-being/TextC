using System;

namespace Practice1._2_1 {
    class Program {
        //Practice1.2-1　MyClassとMyStructの2つの型を引数にとるメソッドPrintObjectsを定義してください。PrintObjectsメソッドでは、2つのオブジェクトの内容（プロパティの値)をコンソールに表示するようにしてください。なお、PrintObjectsメソッドはProgramクラスのメソッドとして定義してください。
        //Practice1.2-2　MainメソッドでPrintObjectsを呼び出すコードを書いてください。MyClass,MyStructオブジェクトの値は、自由に決めてかまいません。
        static void Main(string[] args) {
            MyClass wmyClass = new MyClass { X = 1, Y = 2 };
            MyStruct wmyStruct = new MyStruct { X = 1, Y = 2 };
            PrintObjects(wmyClass, wmyStruct);
            Console.ReadLine();
        }
<<<<<<<< HEAD:章末問題第1章/Practice1.2-1/Program1-2-1,1-2-2.cs
========
        public static void PrintObjects(MyClass vMC, MyStruct vMS) {
            Console.WriteLine("X =" + vMC.X + "Y =" + vMC.Y);
            Console.WriteLine("X =" + vMS.X + "Y =" + vMS.Y);
>>>>>>>> origin/feature/chapter1:章末問題第1章/Practice1.2-1/Program1.2-1,1.2-2.cs

        public static void PrintObjects(MyClass vMC, MyStruct vMS) {
            Console.WriteLine("X =" + vMC.X + "Y =" + vMC.Y);
            Console.WriteLine("X =" + vMS.X + "Y =" + vMS.Y);
        }
<<<<<<<< HEAD:章末問題第1章/Practice1.2-1/Program1-2-1,1-2-2.cs
========

>>>>>>>> origin/feature/chapter1:章末問題第1章/Practice1.2-1/Program1.2-1,1.2-2.cs
    }
}
