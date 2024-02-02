using System;
using TextFileProcessor;

namespace LineCounter {
    class LineCounterProcessor : TextProcessor {
        private int FCount;

        //継承したInitializeクラス
        protected override void Initialize(string vFileName) {
            FCount = 0;
        }

        //継承したExecuteクラス()
        protected override void Execute(string vLine) {
            FCount++;
        }

        //継承したTerminateメソッド
        protected override void Terminate() {
            Console.WriteLine($"{FCount}行");
        }
    }
}
