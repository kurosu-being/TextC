namespace Practice17_3_1 {
    /// <summary>
    /// インターフェイス
    /// </summary>
    public interface ITextFileService {
        /// <summary>
        /// 読み込み前に行う処理
        /// </summary>
        /// <param name="vFname">ファイル名</param>
        void Initialize(string vFname);
        /// <summary>
        /// 読み込み中に行う処理
        /// </summary>
        /// <param name="vLine">行</param>
        void Execute(string vLine);
        /// <summary>
        /// 読み込み後に行う処理
        /// </summary>
        void Terminate();
    }
}
