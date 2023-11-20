using System;

namespace Practice8_3_1 {
    /// <summary>
    /// ストップウォッチのクラス
    /// </summary>
    class TimeWatch {
        private DateTime FStartTime;
        private bool FIsRunning;

        /// <summary>
        /// TimeWatchのコンストラクタ
        /// </summary>
        public TimeWatch() => this.Start();
        /// <summary>
        /// ストップウォッチを始めるメソッド
        /// </summary>
        public void Start() {
            if (FIsRunning) {
                return;
            }

            this.FStartTime = DateTime.Now;
            FIsRunning = true;
        }
        /// <summary>
        /// ストップウォッチを止めるメソッド
        /// </summary>
        /// <returns></returns>
        public TimeSpan Stop() {
            if (!FIsRunning) {
                return TimeSpan.Zero;
            }

            TimeSpan wElapsed = DateTime.Now - this.FStartTime;
            FIsRunning = false;
            return wElapsed;
        }
    }
}

