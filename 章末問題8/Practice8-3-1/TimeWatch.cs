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
            // 計測が開始されている場合は何もしない
            if (FIsRunning) {
                return;
            }

            this.FStopwatch.Restart();
            FIsRunning = true;
        }
        ///// <summary>
        ///// 計測を開始するメソッド
        ///// </summary>
        //public void Start() {
        //    //計測が開始されている場合は何もしない
        //    if (FIsRunning) {
        //        return;
        //    }

        //    this.FStopwatch.Restart();
        //    FIsRunning = true;
        //}

        /// <summary>
        /// 計測を終了するメソッド
        /// </summary>
        /// <returns>計測時間</returns>
        public TimeSpan Stop() {
            //計測が開始されていない場合は何もしない
            if (!FIsRunning) {
                return TimeSpan.Zero;
            }

            this.FStopwatch.Stop();
            FIsRunning = false;
            return this.FStopwatch.Elapsed;
        }
    }
}

