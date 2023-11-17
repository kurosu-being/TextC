using System;
using System.Collections.Generic;

namespace Practice8_3_1 {
    //Practice8-3-1 ある処理時間を計算するTimeWatchクラスを定義して下さい。TimeWatchの使い方を以下に示します。
    /* var wt = new TimeWatch();
       　//処理
       TimeSpan　duration = tw.Stop();
       Console.WriteLine("処理時間は{0}ミリでした。",duration.TotalMilliseconds); 
     */
    class Program {
        static void Main(string[] args) {
            //コーディング規約に合わせtw→wTimeWatch、duration→wDurationに変更
            var wTimeWatch = new TimeWatch();

            Console.WriteLine("処理を開始します。");
            var wList = new List<string> { "a", "b", "c", "d" };
            Console.WriteLine("処理が完了しました。");

            TimeSpan wDuration = wTimeWatch.Stop();
            Console.WriteLine($"処理時間は {wDuration.TotalMilliseconds} ミリ秒でした。");

            //DateTimeを使って実装したクラスTimeWatch_DateTimeを使用
            var wTimeWatchD = new TimeWatch_DateTime();

            Console.WriteLine("処理を開始します。");
            var wListD = new List<string> { "a", "b", "c", "d" };
            Console.WriteLine("処理が完了しました。");

            TimeSpan wDuration2 = wTimeWatchD.Stop();
            Console.WriteLine($"処理時間は {wDuration2.TotalMilliseconds} ミリ秒でした。");
        }
    }
}
