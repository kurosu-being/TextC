using System;
namespace Practice2_2_1 {
    class Program {
        //2.1:距離換算プログラム]のコードを参考に、インチからメートルへの換算表を1インチ刻みでコンソールに出力するプログラムを書いてください。このときのインチの範囲は、1インチから10インチまでとしてください。1インチは0.0254メートルです。
        static void Main(string[] args) {
            PrintMeterToInchList(1, 10);
        }
        /// <summary>
        /// インチからメートルへの対応表を出力
        /// </summary>
        /// <param name="vStart">始めの数値</param>
        /// <param name="vStop">終わりの数値</param>
        static void PrintMeterToInchList(int vStart, int vStop) {
            for (int wInch = vStart; wInch <= vStop; wInch++) {
                double wMeter = InchConverter.ToMeter(wInch);
                Console.WriteLine($"{wInch}in = {wMeter:0.0000}m");
            }
        }
    }
}
