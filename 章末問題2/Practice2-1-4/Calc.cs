using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2_1_4 {
    class Calc {
        /// <summary>
        /// 分を計算するメソッド
        /// </summary>
        /// <param name="vLength">曲の長さ</param>
        /// <returns>曲の分/returns>
        public static int MinuteLength(int vLength){
            return vLength / 60;
        }
        /// <summary>
        /// 秒数を計算するメソッド
        /// </summary>
        /// <param name="vLength">曲の長さ</param>
        /// <returns>曲の秒数</returns>
        public static int SecondLength(int vLength){
            return vLength % 60;
        }
    }
}
