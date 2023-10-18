using System;

namespace 演習問題第1章問2 {
    class Program {
        //Practice1.2-1　MyClassとMyStructの2つの型を引数にとるメソッドPrintObjectsを定義してください。PrintObjectsメソッドでは、2つのオブジェクトの内容（プロパティの値)をコンソールに表示するようにしてください。なお、PrintObjectsメソッドはProgramクラスのメソッドとして定義してください。
        //Practice1.2-2　MainメソッドでPrintObjectsを呼び出すコードを書いてください。MyClass,MyStructオブジェクトの値は、自由に決めてかまいません。
        static void Main(string[] args) {
            MyClass wMyClass = new MyClass { X = 1, Y = 2 };
            MyStruct wMyStruct = new MyStruct { X = 1, Y = 2 };
            PrintObjects(wMyClass, wMyStruct);
            Console.ReadLine();
        }
        /// <summary>
        /// 2つのオブジェクトの内容（プロパティの値)をコンソールに表示するメソッド
        /// </summary>
        /// <param name="vMC">クラス</param>
        /// <param name="vMS">構造体</param>
        public static void PrintObjects(MyClass vMC, MyStruct vMS) {
            Console.WriteLine("X =" + vMC.X + "Y =" + vMC.Y);
            Console.WriteLine("X =" + vMS.X + "Y =" + vMS.Y);
        }
    }
}
