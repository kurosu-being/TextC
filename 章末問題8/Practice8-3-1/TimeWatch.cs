using System;
using System.Diagnostics;

namespace Practice8_3_1 {
    class TimeWatch {
        private Stopwatch FStopwatch;
        private bool FIsRunning;

        /// <summary>
        /// TimeWatchのコンストラクタ
        /// </summary>
        public TimeWatch() {
            this.FStopwatch = new Stopwatch();
            this.Start();
        }
        /// <summary>
        /// ストップウォッチを始めるメソッド
        /// </summary>
        public void Start() {
            if (FIsRunning) {
                return;
            }

            this.FStopwatch.Restart();
            FIsRunning = true;
        }
        /// <summary>
        /// ストップウォッチを止めるメソッド
        /// </summary>
        /// <returns>掛かった時間</returns>
        public TimeSpan Stop() {
            if (!FIsRunning) {
                return TimeSpan.Zero;
            }

            this.FStopwatch.Stop();
            FIsRunning = false;
            return this.FStopwatch.Elapsed;
        }
    }
}

