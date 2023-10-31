using System;

namespace Practice5_2_1 {
    /*コンソールから入力した数字文字列をint型に変換したのち、カンマ付きの数字文字列に変換してください。
    入力した文字列は、intTryParseメソッドで数値に変換してください。*/
    class Program {
        static void Main(string[] args) {
            Console.Write("数字文字列を入力してください: ");
            string wMessage = int.TryParse(Console.ReadLine(), out int wNumber) 
                ?$"カンマ付きの数字文字列:{wNumber.ToString("#,0")}" : "無効な数字文字列です。";
            Console.WriteLine(wMessage);
        }
    }
}
