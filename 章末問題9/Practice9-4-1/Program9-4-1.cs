using System;
using System.IO;

namespace Practice9_4_1 {
    /*Practice9-4-1 指定したディレクトリ直下にあるファイルを別のディレクトリにコピーするプログラムを作成してください。
    その際、コピーするファイル名は、拡張子を含まないファイル名の後ろに、_bakを付加してください。
    つまり、元のファイル名がGreeting.txtならば、コピー先のファイル名はGreeting_bak.txtという名前にします。コピー先に同名のファイルがある場合は置き換えてください。*/
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("指定したディレクトリ直下にあるファイルを別のディレクトリにコピーします。\nまずコピーしたいディレクトリパス,コピー先のディレクトリという形で入力してください。");
            string wSourceDirectory = Console.ReadLine();

            if (!Directory.Exists(wSourceDirectory)) {
                Console.WriteLine("指定されたディレクトリが見つかりません。パスに間違いがないかご確認ください。");
                return;
            }

            Console.WriteLine("次にコピー先のディレクトリのパスを入力して下さい。");
            string wTargetDirectory = Console.ReadLine();

            if (!Directory.Exists(wTargetDirectory)) {
                Console.WriteLine("コピー先のファイルが見つかりません。パスに間違いがないかご確認ください。");
                return;
            }

            string[] wFiles = Directory.GetFiles(wSourceDirectory);

            foreach (string wFile in wFiles) {
                string wFileName = Path.GetFileNameWithoutExtension(wFile);
                string wExtension = Path.GetExtension(wFile);
                string wNewFileName = $"{wFileName}_bak{wExtension}";
                string wNewFilePath = Path.Combine(wTargetDirectory, wNewFileName);

                if (!File.Exists(wNewFilePath)) {
                    File.Copy(wFile, wNewFilePath, true);
                }
            }

            Console.WriteLine("ファイルのコピーが完了しました。");
        }
    }
}
