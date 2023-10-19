using System;

namespace 演習問題第1章問2_3 {
    class Program {
        //Practice1.2-3　PrintObjectsメソッド内で、それぞれのプロパティの値を2倍に変更するコードを追加してください。MainメソッドではPrintObjects呼び出しの後に、MyClass、MyStructオブジェクトのプロパティの値をコンソールに表示するコードを加えてください。
        static void Main(string[] args) {
            MyClass wMyClass = new MyClass { X = 1, Y = 2 };
            MyStruct wMyStruct = new MyStruct { X = 1, Y = 2 };
            PrintObjects(wMyClass, wMyStruct);
            Console.WriteLine(wMyClass.X + "," + wMyClass.Y);
            Console.WriteLine(wMyStruct.X + "," + wMyStruct.Y);
            Console.ReadLine();
        }
        /// <summary>
        /// クラス・構造体のプロパティの値を2倍に変更するメソッド
        /// </summary>
        /// <param name="vMC">クラス</param>
        /// <param name="vMS">構造体</param>
        public static void PrintObjects(MyClass vMC, MyStruct vMS) {
            vMC.X *= 2;
            vMC.Y *= 2;
            vMS.X *= 2;
            vMS.Y *= 2;
        }
    }
}
