using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5_2_1 {
    /*コンソールから入力した数字文字列をint型に変換したのち、カンマ付きの数字文字列に変換してください。
    入力した文字列は、intTryParseメソッドで数値に変換してください。*/
    class Program {
        static void Main(string[] args) {
            Console.Write("数字文字列を入力してください: ");
            if (int.TryParse(Console.ReadLine(), out int wNumber)) {
                string wFormatNumber = wNumber.ToString("#,0"); 
                Console.WriteLine("カンマ付きの数字文字列: " + wFormatNumber);
            } 
            else {
                Console.WriteLine("無効な数字文字列です。");
            }

            //Console.WriteLine("数字を入力してください");
            //string wInput = Console.ReadLine();
            //var wOutput = wInput;
            //int wInt;
            //if ( int.TryParse(wInput, out wInt)){
            //    Console.WriteLine($"{wOutput.ToString("#")");
            //}
            
    }
}
}
