using System;

namespace Practice17_3_1 {
    /// <summary>
    ///　全角数字から半角数字に変換し、行数を数える機能を持つクラス
    /// </summary>
    public class ToHankakuService : ITextFileService {
        //継承したInitializeメソッド
        public void Initialize(string vFileName) {
        }

        //継承したExecuteメソッド（半角数字に変換してコンソールに結果を表示)
        public void Execute(string vLine) {
            string wConvertedLine = ConvertFullWidthDigitsToHalfWidth(vLine);
            Console.WriteLine(wConvertedLine);
        }

        /// <summary>
        /// ファイルの内容から文字を判定し、全角数字を半角数字に変換した文字列を返す処理を行うメソッド
        /// </summary>
        /// <param name="vInput">ファイルの文字列</param>
        /// <returns>半角数字に変換した文字列</returns>
        private string ConvertFullWidthDigitsToHalfWidth(string vInput) {
            char[] wConvertedChars = new char[vInput.Length];

            for (int i = 0; i < vInput.Length; i++) {
                char wCurrentChar = vInput[i];

                if (IsFullWidthDigit(wCurrentChar)) {
                    wConvertedChars[i] = ConvertToHalfWidthDigit(wCurrentChar);
                } else {
                    wConvertedChars[i] = wCurrentChar;
                }
            }

            return new string(wConvertedChars);
        }

        /// <summary>
        ///  全角数字であるかのフラグ
        /// </summary>
        /// <param name="vChar">文字</param>
        /// <returns>全角数字であるか否か</returns>
        private bool IsFullWidthDigit(char vChar) {
            return char.IsDigit(vChar) && vChar >= '０' && vChar <= '９';
        }

        /// <summary>
        /// 全角数字を半角数字に変換するメソッド
        /// </summary>
        /// <param name="vChar">文字</param>
        /// <returns>半角数字に変換した文字</returns>
        private char ConvertToHalfWidthDigit(char vChar) {
            //全角数字での差分を計算し、半角0に足す（文字コードの差分が同じであることを利用）
            return (char)(vChar - '０' + '0');
        }

        public void Terminate() {
        }
    }
}
