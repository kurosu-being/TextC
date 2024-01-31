using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextFileProcessor {
    public abstract class TextProcessor {
        public static void Run<T>(string vFileName) where T : TextProcessor, new() {
            var wSelf = new T();
            wSelf.Process(vFileName);
        }

        private void Process(string vFileName) {
            Initialize(vFileName);
            using (var wStreamReader = new StreamReader(vFileName)) {
                while (!wStreamReader.EndOfStream) {
                    string wLine = wStreamReader.ReadLine();
                    Execute(wLine);
                    SearchNumber(vFileName);
                }
            }
            Terminate();
        }

        protected virtual void Initialize(string vFname) { }
        protected virtual void Execute(string vFname) { }
        protected virtual void SearchNumber(string vFname) { }

        // 派生クラスで必要に応じてオーバーライド可能にするために protected virtual に変更
        protected virtual string ConvertFullWidthDigitsToHalfWidth(string vInput) {
            return vInput; // デフォルトでは変換しない
        }

        protected virtual void Terminate() { }
    }
}
