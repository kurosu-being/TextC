using System.IO;

namespace Practice17_3_1 {
    /// <summary>
    /// 処理の流れのテンプレートとなるクラス
    /// </summary>
    public class TextFileProcessor {
        private ITextFileService FService;

        public TextFileProcessor(ITextFileService vService) {
            FService = vService;
        }

        /// <summary>
        /// ファイルを読み込み、処理を行う一連の処理
        /// </summary>
        /// <param name="vFileName">ファイルの名前</param>
        public void Run(string vFileName) {
            FService.Initialize(vFileName);
            using (var wStreamReader = new StreamReader(vFileName)) {
                while (!wStreamReader.EndOfStream) {
                    string wLine = wStreamReader.ReadLine();
                    FService.Execute(wLine);
                }
            }
            FService.Terminate();
        }
    }
}
