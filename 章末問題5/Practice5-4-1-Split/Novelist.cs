using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5_4_1_Split {
    class Novelist {
        public string Writer { get; private set; }
        public string BestWork { get; private set; }
        public int Born { get; private set; }

        public Novelist(string vSentence) {
            var parts = vSentence.Split(';')
                .Select(part => part.Split('='))
                .ToDictionary(pair => pair[0], pair => pair[1]);

            if (parts.ContainsKey("Novelist"))
                this.Writer = parts["Novelist"];
            if (parts.ContainsKey("BestWork"))
                this.BestWork = parts["BestWork"];
            if (parts.ContainsKey("Born") && int.TryParse(parts["Born"], out int wBornYear))
                this.Born = wBornYear;
        }
    }
}
