using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3_2_2 {
    class Program {
        static void Main(string[] args) {
            var wNumbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };
            var wWhere = wNumbers.Select(s => s * 2).ToList();
            foreach (int wN in wWhere) {
                Console.WriteLine(wN);
            }
    }
}
}
