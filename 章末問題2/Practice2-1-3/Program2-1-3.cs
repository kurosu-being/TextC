namespace Practice2_1_3 {
    class Program {
        //Practice2-1-3 作成したSongクラスのインスタンスを複数生成し、配列songsに格納してください。
        static void Main(string[] args) {
            Song wSong1 = new Song("白日", "KingGnu", 240);
            Song wSong2 = new Song("アイドル", "YOASOBI", 210);
            Song wSong3 = new Song("天体観測", "BUMP OF CHICKEN", 190);
            //配列songsに格納
            Song[] songs = { wSong1, wSong2, wSong3 };
        }
    }
}
