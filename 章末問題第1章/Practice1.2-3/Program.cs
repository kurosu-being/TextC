using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1._2_1 {
    class Program {
        //Practice1.2-3　PrintObjectsメソッド内で、それぞれのプロパティの値を2倍に変更するコードを追加してください。MainメソッドではPrintObjects呼び出しの後に、MyClass、MyStructオブジェクトのプロパティの値をコンソールに表示するコードを加えてください。
        static void Main(string[] args) {
            MyClass myClass = new MyClass { X = 1, Y = 2 };
            MyStruct myStruct = new MyStruct { X = 1, Y = 2 };
            PrintObjects(myClass, myStruct);
            Console.WriteLine(myClass.X + "," + myClass.Y);
            Console.WriteLine(myStruct.X + "," + myStruct.Y);
            Console.ReadLine();
        }
        public static void PrintObjects(MyClass MC, MyStruct MS) {
            MC.X *= 2;
            MC.Y *= 2;
            MS.X *= 2;
            MS.Y *= 2;
        }

    }
}
