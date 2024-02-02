using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileProcessor;

namespace LineCounter {
    class ToHankakuNumber : TextProcessor {

        //継承したInitializeクラス(0を入れたフィールド変数を用意)
        protected override void Initialize(string vFileName) {
        }

        //継承したExecuteクラス()
        protected override void Execute(string vLine) {
            string wConvertedLine = ConvertFullWidthDigitsToHalfWidth(vLine);
            Console.WriteLine(wConvertedLine);
        }

        // 派生クラスで実際の変換ロジックを実装
        protected override string ConvertFullWidthDigitsToHalfWidth(string input) {
            char[] wConvertedChars = new char[input.Length];

            for (int i = 0; i < input.Length; i++) {
                char wCurrentChar = input[i];

                if (IsFullWidthDigit(wCurrentChar)) {
                    // 全角数字を半角数字に変換
                    wConvertedChars[i] = ConvertToHalfWidthDigit(wCurrentChar);
                } else {
                    wConvertedChars[i] = wCurrentChar;
                }
            }

            return new string(wConvertedChars);
        }

        // 文字が全角数字かどうかを判定するメソッド
        private bool IsFullWidthDigit(char c) {
            return char.IsDigit(c) && c >= '０' && c <= '９';
        }

        // 全角数字を半角数字に変換するメソッド
        private char ConvertToHalfWidthDigit(char c) {
            return (char)(c - '０' + '0');
        }

        //継承したTerminateメソッド
        protected override void Terminate() {
        }
    }
}