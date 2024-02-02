using TextFileProcessor;

namespace LineCounter {
    class Program {
        static void Main(string[] args) {
            TextProcessor.Run<LineCounterProcessor>(args[0]);
        }
    }
}
