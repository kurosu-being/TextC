using TextFileProcessor;

namespace LineCounter {
    //テキストで使用したTextProcessorクラスを使い、テキストファイルの中の全角数字を半角数字に置き換えて、置き換えた結果をコンソールに出力するプログラムを作ってください。
    class Program {
        static void Main(string[] args) {
            TextProcessor.Run<ToHankakuNumber>(args[0]);
        }
    }
}
