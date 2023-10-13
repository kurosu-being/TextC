using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1._2_1 {
    class Program {
        //MyClassとMyStructの2つの方を引数にとるメソッドPrintObjectsを定義してください。PrintObjectsメソッドでは、2つのオブジェクトの内容（プロパティの値)をコンソールに表示するようにしてください。なお、PrintObjectsメソッドはProgramクラスのメソッドとして定義してください。、
        static void Main(string[] args) {
            MyClass myClass = new MyClass { X = "1", Y = 2 };
            MyStruct myStruct = new MyStruct { X = 1, Y = 2 };
            PrintObjects(myClass,myStruct);
            MyClass myClass2 = new MyClass { X = "10", Y = 20 };
            MyStruct myStruct2 = new MyStruct { X = 100, Y = 200 };
            PrintObjects(myClass2, myStruct2);
            Console.ReadLine();
        }



        public static void PrintObjects(MyClass MC, MyStruct myStruct) {
            Console.WriteLine("X =" + MC.X +"Y =" + MC.Y);
            Console.WriteLine(myStruct.X + myStruct.Y);
            
        }
       
    }
}
