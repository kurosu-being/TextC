using System;
using TextFileProcessor;

namespace LineCounter {
    /// <summary>
    /// 行数を数える機能を持ったクラス
    /// </summary>
    class LineCounterProcessor : TextProcessor {
        private int FCount;

        //継承したInitializeクラス（0の入ったフィールド変数を用意）
        protected override void Initialize(string vFileName) {
            FCount = 0;
        }

        //継承したExecuteクラス(一行ごとカウントする)
        protected override void Execute(string vLine) {
            FCount++;
        }

        //継承したTerminateメソッド（コンソールに行数を出力する）
        protected override void Terminate() {
            Console.WriteLine($"{FCount}行");
        }
    }
}
