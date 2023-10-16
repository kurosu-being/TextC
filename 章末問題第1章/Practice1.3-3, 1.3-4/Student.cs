using System;

namespace Practice1._3_1 {
    class Student : Person {
        public int Grade { get; set; }
        public int ClassNumber { get; set; }
        public Student() {
            this.Name = "黒子";
            this.Birthday = new DateTime(2000, 2, 2);
            this.Grade = 3;
            this.ClassNumber = 10;
        }
    }
}
