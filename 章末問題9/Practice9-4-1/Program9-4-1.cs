using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9_4_1 {
    /*Practice9-4-1 指定したディレクトリ直下にあるファイルを別のディレクトリにコピーするプログラムを作成してください。
    その際、コピーするファイル名は、拡張子を含まないファイル名の後ろに、_bakを付加してください。
    つまり、元のファイル名がGreeting.txtならば、コピー先のファイル名はGreeting_bak.txtという名前にします。コピー先に同名のファイルがある場合は置き換えてください。*/
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("パスを入力してください");
            string wFilePath = Console.ReadLine();

            if (Directory.Exists(wFilePath)){

            }
        }
    }
}
