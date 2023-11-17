using System;
using System.Collections.Generic;

namespace SSS {
    class Program {
        static void Main(string[] args) {
            var wLine = Console.ReadLine();
            string[] wNums = wLine.Split(' ');
            var wList = new List<int>();
            foreach (string wNum in wNums) {
                var wNum1 = int.Parse(wNum);
                wList.Add(wNum1);
            }
            var wNumEX = wList.ToArray();
            if (wNumEX[0] * wNumEX[1] <= wNumEX[2]) {
                Console.WriteLine("YES");
            } else {
                Console.WriteLine("No");
            }
        }
    }
}



