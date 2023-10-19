using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2_1_4 {
    class Calc {
        public static int MinuteLength(int vLength){
            return vLength / 60;
        }
        public static int SecondLength(int vLength){
            return vLength % 60;
        }
    }
}
