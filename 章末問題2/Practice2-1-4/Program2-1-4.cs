namespace Practice2_1_4 {
    class Program {
        //配列に格納されたすべてのSongオブジェクトの内容をコンソールに出力してください。演奏時間の表示は「4:16」のような書式にしてください。ただし、演奏時間は必ず60分未満と仮定してかまいません。
        static void Main(string[] args) {
            Song song1 = new Song("白日", "KingGnu", 240);
            Song song2 = new Song("アイドル", "YOASOBI", 250);
            Song song3 = new Song("天体観測", "BUMP OF CHICKEN", 190);
            //配列songsに格納
            Song[] songs = { song1, song2, song3 };
        }
    }
}
