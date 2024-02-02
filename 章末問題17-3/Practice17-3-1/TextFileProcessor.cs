using System.IO;

namespace Practice17_3_1 {
    public class TextFileProcessor {
        private ITextFileService FService;

        public TextFileProcessor(ITextFileService vService) {
            FService = vService;
        }

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
