using System;

namespace Practice1._2_1 {
    class Program {
        //Practice1.2-3　PrintObjectsメソッド内で、それぞれのプロパティの値を2倍に変更するコードを追加してください。MainメソッドではPrintObjects呼び出しの後に、MyClass、MyStructオブジェクトのプロパティの値をコンソールに表示するコードを加えてください。
        static void Main(string[] args) {
            MyClass wmyClass = new MyClass { X = 1, Y = 2 };
            MyStruct wmyStruct = new MyStruct { X = 1, Y = 2 };
            PrintObjects(wmyClass, wmyStruct);
            Console.WriteLine(wmyClass.X + "," + wmyClass.Y);
            Console.WriteLine(wmyStruct.X + "," + wmyStruct.Y);
            Console.ReadLine();
        }
        public static void PrintObjects(MyClass vMC, MyStruct vMS) {
            vMC.X *= 2;
            vMC.Y *= 2;
            vMS.X *= 2;
            vMS.Y *= 2;
        }

    }
}
