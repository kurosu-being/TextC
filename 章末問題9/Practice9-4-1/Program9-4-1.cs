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
            Console.WriteLine("1つ目のテキストファイルの最後に、2つ目のテキストファイルの内容を追加します。\n1つ目のファイルパス,2つ目のファイルパスという書き方で指定してください");
            string wFilePath = Console.ReadLine();

            if (wFilePath.Split(',').Length != 2) {
                Console.WriteLine("正しい数のパスが提供されていません。最初の引数に元のファイル、次の引数に追記先のファイルを指定してください。");
                return;
            }

            string wSourceDirectory = wFilePath.Split(',')[0];
            string wTargetDirectory = wFilePath.Split(',')[1];
            if (!File.Exists(wSourceDirectory) || !File.Exists(wTargetDirectory)) {
                Console.WriteLine("指定されたファイルが見つかりません。パスに間違いがないかご確認ください。");
                return;
            }

            string[] wFiles = Directory.GetFiles(wSourceDirectory);

            foreach (string wFile in wFiles) {
                // ファイル名と拡張子を取得
                string wFileName = Path.GetFileNameWithoutExtension(wFile);
                string wExtension = Path.GetExtension(wFile);

                // 新しいファイル名を作成
                string wNewFileName = $"{wFileName}_Bak{wExtension}";

                // コピー先のパスを作成
                string wDestFilePath = Path.Combine(wTargetDirectory, wNewFileName);

                // コピー先に同名のファイルがなければコピーを実行
                if (!File.Exists(wDestFilePath)) {
                    File.Copy(wFilePath, wDestFilePath);
                    Console.WriteLine($"{wFile} を {wDestFilePath} にコピーしました。");
                }
            }

            Console.WriteLine("ファイルのコピーが完了しました。");
        }
    }
}
