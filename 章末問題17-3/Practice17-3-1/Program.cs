namespace Practice17_3_1 {
    class Program {
        static void Main(string[] args) {
            var wToHankakuService = new ToHankakuService();
            var wProcessor = new TextFileProcessor(wToHankakuService);

            wProcessor.Run(args[0]);
        }
    }
}
