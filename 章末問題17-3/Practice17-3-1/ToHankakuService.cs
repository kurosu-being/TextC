using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice17_3_1 {
    public class ToHankakuService : ITextFileService {
        private int FCount;

       public void Initialize(string vFileName) {
            FCount = 0;
        }

       public void Execute(string vLine) {
            FCount++;
            string wConvertedLine = ConvertFullWidthDigitsToHalfWidth(vLine);
            Console.WriteLine(wConvertedLine);
        }

        // 派生クラスで実際の変換ロジックを実装
        private string ConvertFullWidthDigitsToHalfWidth(string input) {
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

        public void  Terminate() {
            Console.WriteLine($"{FCount}行");
        }
    }
}
