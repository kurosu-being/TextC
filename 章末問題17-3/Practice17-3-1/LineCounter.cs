using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice17_3_1 {
    public class LineCounter : ITextFileService {
        private int FCount;

        public void Initialize(string vFileName) {
            FCount = 0;
        }

        public void Execute(string vLine) {
            FCount++;
        }

        public void Terminate() {
            Console.WriteLine($"{FCount}行");
        }
    }
}