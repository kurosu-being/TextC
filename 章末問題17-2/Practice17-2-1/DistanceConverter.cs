using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice17_2_1 {
    public class DistanceConverter {
        public ConverterBase From { get; private set;}
        public ConverterBase To { get; private set; }

        //コンストラクタ
        public DistanceConverter(ConverterBase vFrom, ConverterBase vTo) {
            From = vFrom;
            To = vTo;
        }

        public double Convert(double vValue) {
            var wMeter = From.ToMeter(vValue);
            return To.FromMeter(wMeter);
        }
    }
}
