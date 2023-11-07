using System;

namespace Practice5_1_1 {
    /*Practice5-1-1 コンソールから入力した2つの文字列が等しいか調べるコードを書いてください。
    このとき、大文字、小文字の違いは無視するようにしてください。
    コンソールからの入力の時は、Console.ReadLineメソッドを利用してください。*/
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("「○○,■■」という形で2つの文字列を入力してください");
            string wInput = Console.ReadLine();
            string[] wInputArray = wInput.Split(',');
            if (wInputArray.Length == 2) {
                string wJudge = string.Compare(wInputArray[0].Trim(), wInputArray[1].Trim(), true) == 0
                      ? "一致しています": "不一致です。";
                Console.WriteLine(wJudge);
            } else{
                string wErrorMessage = string.IsNullOrEmpty(wInput)
                    ? "入力が空です。文字列を入力してください。" : "入力された文字列の数が指定と違います";
                Console.WriteLine(wErrorMessage);
            }
        }
    }
}
