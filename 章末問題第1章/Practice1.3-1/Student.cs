using System;

namespace Practice1._3_1 {
    class Student : Person {
        /// <summary>
        /// 学年
        /// </summary>
        public int Grade { get; set; }
        /// <summary>
        /// 組
        /// </summary>
        public int ClassNumber { get; set; }
        /// <summary>
        /// Studentクラスのコンストラクタ
        /// </summary>
        /// <param name="vName">名前</param>
        /// <param name="vDay">日付</param>
        /// <param name="vGrade">学年</param>
        /// <param name="vClassNumber">組</param>
        public Student(string vName, DateTime vDay, int vGrade, int vClassNumber) {
            this.Name = vName;
            this.Birthday = vDay;
            this.Grade = vGrade;
            this.ClassNumber = vClassNumber;
        }
    }
}
