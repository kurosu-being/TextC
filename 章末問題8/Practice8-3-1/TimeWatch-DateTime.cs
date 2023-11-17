using System;

namespace Practice8_3_1 {
    class TimeWatch_DateTime {
        private DateTime FStartTime;
        private bool FIsRunning;

        /// <summary>
        /// imeWatch_DateTimeのコンストラクタ
        /// </summary>
        public TimeWatch_DateTime() {
            this.Start();
        }
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