using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5_1_1 {
    /*Practice5-1-1 コンソールから入力した2つの文字列が等しいか調べるコードを書いてください。
    このとき、大文字、小文字の違いは無視するようにしてください。
    コンソールからの入力の時は、Console.ReadLineメソッドを利用してください。*/
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("[○○,■■」という形で2つの文字列を入力してください");
            string wInput = Console.ReadLine();
            string wMessage = string.IsNullOrEmpty(wInput)
            ? "入力が空です。文字列を入力してください。":(wInput.Split(',').Length == 2 && string.Compare(wInput.Split(',')[0], wInput.Split(',')[1], true) == 0)
            ? "一致しています":"不一致です";
            Console.WriteLine(wMessage);
        }
    }
}
