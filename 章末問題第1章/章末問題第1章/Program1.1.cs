using Henkou;
using System;

namespace 章末問題第1章 {
    class Program {
        //Practice1.1-1 どら焼きオブジェクトを生成するコードを書いてください。この時の商品番号は98、商品価格は"210円"としてください。
        //Practice1.1-2　どら焼きオブジェクトの消費税額を求め、コンソールに出力するコードを書いてください
        //Productクラスが属する名前空間を別の名前空間に変更し、Mainメソッドから呼び出すようにしてください。ただし、MainメソッドのあるProgramクラスの名前空間はそのままとしてください。
        static void Main(string[] args) {
            Product wdorayaki = new Product(98, "どら焼き", 210);
            Console.WriteLine("消費税額は" + wdorayaki.GetTax() + "円です");
        }
    }
}
