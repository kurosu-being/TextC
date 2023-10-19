using System;

namespace Practice2_2_1 {
    class Program {
        //[2.1:距離換算プログラム]のコードを三個王に、インチからメートルへの換算表を1インチ刻みでコンソールに出力するプログラムを書いてください。このときのインチの範囲は、1インチから10インチまでとしてください。1インチは0.0254メートルです。
        static void Main(string[] args) {
            PrintMeterToInchList(1, 10);
        }
        /// <summary>
        /// メートルからインチへの対応表を出力
        /// </summary>
        /// <param name="vStart">始めの数値</param>
        /// <param name="vStop">終わりの数値</param>
        static void PrintMeterToInchList(int vStart, int vStop) {
            for (int wMeter = vStart; wMeter <= vStop; wMeter++) {
                double wInch = ConvertFeet.FromMeter(wMeter);
                Console.WriteLine($"{wMeter}m = {wInch:0.0000}in");
            }
        }
    }
}
