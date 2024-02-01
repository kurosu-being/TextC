using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice17_2_1 {
    static class ConverterFactory {
        //あらかじめインスタンスを生成し、配列に入れておく
        private static ConverterBase[] FConverters = new ConverterBase[]{
            new MeterConverter(),
            new FeetConverter(),
            new YardConverter(),
            new InchConverter(),
        };

        public static ConverterBase GetInstance(string vName) {
            return FConverters.FirstOrDefault(x => x.IsMyUnit(vName));
        }
    }
}
