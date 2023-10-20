using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3_1_2 {
    class Program {
        //List<T>のメソッドを使い、書く要素を2.0で割った値をコンソールに出力してください。
        static void Main(string[] args) {
            var wNumbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };
            wNumbers.ForEach(s => Console.WriteLine(s /2.0));
        }
    }
}
