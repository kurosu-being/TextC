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
            if (FIsRunning) {
                return;
            }

            this.FStopwatch.Restart();
            FIsRunning = true;
        }

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

