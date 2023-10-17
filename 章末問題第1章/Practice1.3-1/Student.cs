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
        /// 名前の引数
        /// <param name="vName"></param>
        /// 日付の引数
        /// <param name="vDay"></param>
        /// 学年の引数
        /// <param name="vGrade"></param>
        /// 組の引数
        /// <param name="vClassNumber"></param>
        public Student(string vName, DateTime vDay, int vGrade, int vClassNumber) {
            this.Name = vName;
            this.Birthday = vDay;
            this.Grade = vGrade;
            this.ClassNumber = vClassNumber;
        }
    }
}
