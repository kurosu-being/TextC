﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Henkou;

namespace 章末問題第1章 {
    class Program {
        //Practice1.1-1 どら焼きオブジェクトを生成するコードを書いてください。この時の商品番号は98、商品価格は"210円"としてください。
        //Practice1.1-2　どら焼きオブジェクトの消費税額を求め、コンソールに出力するコードを書いてください
        static void Main(string[] args) {
            Product dorayaki = new Product(98, "どら焼き", 210);
            Console.WriteLine("消費税額は" + dorayaki.GetTax());
        }
    }
}
