﻿using System;

namespace Practice2_1_4_追加問題_ {
    class Program {
        //追加問題1 さらに新しくSongクラスのインスタンスを生成して、wSongsに追加する処理を書いてみてください。
        //追加問題2 自作メソッドを使わずに、TimeSpan構造体を使って同等の処理を書いてみてください。※前のコードは残したままでよいですと仮定してかまいません。
        static void Main(string[] args) {
            Song wSong1 = new Song("白日", "KingGnu", 241);
            Song wSong2 = new Song("アイドル", "YOASOBI", 275);
            Song wSong3 = new Song("天体観測", "BUMP OF CHICKEN", 1190);
            //配列songsに格納
            Song[] wSongs = { wSong1, wSong2, wSong3 };
            // 追加問題１Songクラスのインスタンスを生成
            Song wSong4 = new Song("君が代", "林広守", 240);
            // 配列のサイズを拡張して新しい曲を追加
            Array.Resize(ref wSongs, wSongs.Length + 1);
            wSongs[wSongs.Length - 1] = wSong4;
            // 配列に格納されたSongクラスのインスタンスをコンソールに出力
            foreach (Song wSong in wSongs) {
                //追加問題2 TimeSpan構造体を利用
                TimeSpan wTimeSpan = TimeSpan.FromSeconds(wSong.Length);
                Console.WriteLine($"{wSong.Title}という曲のアーティストは {wSong.ArtistName}で曲の長さは{wTimeSpan.Minutes:D1}:{wTimeSpan.Seconds:D2}です");
            }
        }
    }
}
