using System;
using System.Diagnostics;
using System.IO;

namespace Practice14_1_1 {
    //Practice14-1-1 ファイルにプログラムのパスとパラメータが複数行書かれています。このファイルを読み込み、プログラムを順に起動するプログラムを書いてください。1つのプログラムが終わるのを待って次のプログラムを起動してください。入力するファイルの形式は、通常のテキストファイルでもXMLファイルでも、好みの形でかまいません。
    class Program {
        static void Main() {
            Console.WriteLine("問14-1-1.txtファイルのパスを入力してください。");
            string wFilePath = Console.ReadLine();
            if (!File.Exists(wFilePath)) {
                Console.WriteLine("ファイルが存在しません。パスに間違いがないかご確認ください。");
            }

            string[] wLines = File.ReadAllLines(wFilePath);

            foreach (string wLine in wLines) {
                string[] wParts = wLine.Split(new char[] { ' ' }, 2); //実行ファイルと引数を分ける

                if (wParts.Length >= 1) {
                    string wProgramPath = wParts[0]; // プログラムのパス
                    string wArguments = wParts.Length == 2 ? wParts[1] : ""; // パラメータがあれば取得、なければ空文字列

                    LaunchProgram(wProgramPath, wArguments);
                }
            }

            Console.WriteLine("すべてのプログラムの起動が完了しました。");
            Console.ReadLine();
        }

        /// <summary>
        /// プロセスを開始し、終了を待つメソッド
        /// </summary>
        /// <param name="path">ファイルのパス</param>
        /// <param name="arguments">パラメータ</param>
        static void LaunchProgram(string path, string arguments) {
                Process.Start(path, arguments)?.WaitForExit(); 
        }
    }
}




