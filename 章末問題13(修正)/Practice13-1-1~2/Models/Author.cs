using System;
using System.Collections.Generic;

namespace Practice13_1_1_2.Models {
    /// <summary>
    /// 著者クラス
    /// </summary>
    public class Author {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 著者名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 著者の誕生日
        /// </summary>
        public DateTime Birthday { get; set; }
        /// <summary>
        /// 性別
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// 作品
        /// </summary>
        public virtual ICollection<Book> Books { get; set; }

        //コンストラクタ
        public Author(int vId, string vName, DateTime vBirthday, string vGender, ICollection<Book> vBooks) {
            this.Id = vId;
            this.Name = vName;
            this.Birthday = vBirthday;
            this.Gender = vGender;
            this.Books = vBooks;
        }
        //コンストラクタ
        public Author() { }
    }
}

