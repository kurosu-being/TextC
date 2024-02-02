using System;

namespace Practice17_3_1 {
    /// <summary>
    ///　具体的な処理の機能を持つクラス
    /// </summary>
    public class ToHankakuService : ITextFileService {
        private int FCount;

        //継承したInitializeメソッド（フィールド変数を用意）
        public void Initialize(string vFileName) {
            FCount = 0;
        }

        //継承したExecuteメソッド（一行ごとに加算し、半角数字に変換してコンソールに結果を表示
        public void Execute(string vLine) {
            FCount++;
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
        /// <param name="c">文字</param>
        /// <returns>全角数字であるか否か</returns>
        private bool IsFullWidthDigit(char c) {
            return char.IsDigit(c) && c >= '０' && c <= '９';
        }

        /// <summary>
        /// 全角数字を半角数字に変換するメソッド
        /// </summary>
        /// <param name="c">文字</param>
        /// <returns>半角数字に変換した文字</returns>
        private char ConvertToHalfWidthDigit(char c) {
            return (char)(c - '０' + '0');
        }

        //継承したTerminateメソッド(カウントした行数をコンソールに出力)
        public void Terminate() {
            Console.WriteLine($"{FCount}行");
        }
    }
}
