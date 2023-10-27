namespace Practice2_1_3 {
    /// <summary>
    /// 歌のクラス
    /// </summary>
    class Song {
        /// <summary>
        /// 歌のタイトル
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// アーティスト名
        /// </summary>
        public string ArtistName { get; set; }
        /// <summary>
        /// 演奏時間（単位は秒）
        /// </summary>
        public int Length { get; set; }
        /// <summary>
        /// Songクラスのコンストラクタ
        /// </summary>
        /// <param name="vTitle">歌のタイトル</param>
        /// <param name="vArtistName">アーティスト名</param>
        /// <param name="vLength">演奏時間（単位は秒）</param>
        public Song(string vTitle, string vArtistName, int vLength) {
            this.Title = vTitle;
            this.ArtistName = vArtistName;
            this.Length = vLength;
        }
    }
}
