namespace Practice2_1_3 {
    class Program {
        //Practice2-1-3 作成したSongクラスのインスタンスを複数生成し、配列songsに格納してください。
        static void Main(string[] args) {
            Song song1 = new Song("白日", "KingGnu", 240);
            Song song2 = new Song("アイドル", "YOASOBI", 210);
            Song song3 = new Song("天体観測", "BUMP OF CHICKEN", 190);
            //配列songsに格納
            Song[] songs = { song1, song2, song3 };
        }
    }
}
