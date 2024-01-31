using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice17_2_1 {
    public abstract class ConverterBase {
        //メートルとの比率（この比率をかけるとメートルに変換できる）
        protected abstract double Ratio { get; }

        //距離の単位名（たとえば、"メートル"、"フィート"など）
        public abstract string UnitName { get; }

        //メートルからの変換
        public double FromMeter(double vMeter) {
            return vMeter / Ratio;
        }

        //メートルへ変換
        public double ToMeter(double vFeet) {
            return vFeet * Ratio;
        }
    }
}
