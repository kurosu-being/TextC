using System;
using TextFileProcessor;

namespace LineCounter {
    /// <summary>
    /// 全角数字を半角数字に変換する機能を持ったクラス
    /// </summary>
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
        protected override string ConvertFullWidthDigitsToHalfWidth(string vInput) {
            char[] wConvertedChars = new char[vInput.Length];

            for (int i = 0; i < vInput.Length; i++) {
                char wCurrentChar = vInput[i];

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
        private bool IsFullWidthDigit(char vChar) {
            return char.IsDigit(vChar) && vChar >= '０' && vChar <= '９';
        }

        // 全角数字を半角数字に変換するメソッド
        private char ConvertToHalfWidthDigit(char vChar) {
            return (char)(vChar - '０' + '0');
        }

        //継承したTerminateメソッド
        protected override void Terminate() {
        }
    }
}