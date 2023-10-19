using System;

namespace Practice2_1_4 {
    class Program {
        //Practice2-1-4 配列に格納されたすべてのSongオブジェクトの内容をコンソールに出力してください。演奏時間の表示は「4:16」のような書式にしてください。ただし、演奏時間は必ず60分未満と仮定してかまいません。
        static void Main(string[] args) {
            Song wSong1 = new Song("白日", "KingGnu", 241);
            Song wSong2 = new Song("アイドル", "YOASOBI", 275);
            Song wSong3 = new Song("天体観測", "BUMP OF CHICKEN", 1190);
            //配列songsに格納
            Song[] songs = { wSong1, wSong2, wSong3 };
            // 配列に格納されたSongクラスのインスタンスをコンソールに出力
            foreach (Song song in songs) {
                int wShowMinute = Calc.MinuteLength(song.Length);
                int wShowSecond = Calc.SecondLength(song.Length);
                Console.WriteLine($"{song.Title}という曲のアーティストは {song.ArtistName}で曲の長さは{wShowMinute:D1}:{wShowSecond:D2}です");
            }
        }
    }
}
