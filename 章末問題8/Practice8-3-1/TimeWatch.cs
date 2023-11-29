using System;

namespace Practice8_3_1 {
    /// <summary>
    /// ストップウォッチのクラス
    /// </summary>
    class TimeWatch {
        private DateTime FStartTime;
        /// <summary>
        /// ストップウォッチが実行中かどうかを示すプロパティ
        /// </summary>
        private bool IsRunning => this.FStartTime != default(DateTime);

        /// <summary>
        /// TimeWatchのコンストラクタ
        /// </summary>
        public TimeWatch() => this.Start();

        /// <summary>
        /// ストップウォッチを始めるメソッド
        /// </summary>
        public void Start() {
            if (this.IsRunning) return;
            this.FStartTime = DateTime.Now;
        }

        /// <summary>
        /// ストップウォッチを止めるメソッド
        /// </summary>
        /// <returns></returns>
        public TimeSpan Stop() {
            try {
                return this.IsRunning ? (DateTime.Now - this.FStartTime) : TimeSpan.Zero;
            } finally {
                this.FStartTime = default(DateTime);
            }
        }
    }
}


