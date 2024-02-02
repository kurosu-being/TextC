using System;

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