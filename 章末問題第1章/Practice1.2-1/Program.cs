using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1._2_1 {
    class Program {
        //Practice1.2-1　MyClassとMyStructの2つの方を引数にとるメソッドPrintObjectsを定義してください。PrintObjectsメソッドでは、2つのオブジェクトの内容（プロパティの値)をコンソールに表示するようにしてください。なお、PrintObjectsメソッドはProgramクラスのメソッドとして定義してください。
        //Practice1.2-2　MainメソッドでPrintObjectsを呼び出すコードを書いてください。MyClass,MyStructオブジェクトの値は、自由に決めてかまいません。
        static void Main(string[] args) {
            MyClass myClass = new MyClass { X = 1, Y = 2 };
            MyStruct myStruct = new MyStruct { X = 1, Y = 2 };
            PrintObjects(myClass,myStruct);
            Console.ReadLine();
        }
        public static void PrintObjects(MyClass vMC, MyStruct vMS) {
            Console.WriteLine("X =" + vMC.X +"Y =" + vMC.Y);
            Console.WriteLine("X =" + vMS.X + "Y =" + vMS.Y);

        }
       
    }
}
