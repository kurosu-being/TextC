namespace Practice17_3_1 {
    //Practice17-3-1 17-1-1で作成したプログラムをこの構造（チケットに貼っています)に合うように書き換えてください。
    class Program {
        static void Main(string[] args) {
            var wToHankakuService = new ToHankakuService();
            var wProcessor = new TextFileProcessor(wToHankakuService);

            wProcessor.Run(args[0]);
        }
    }
}
