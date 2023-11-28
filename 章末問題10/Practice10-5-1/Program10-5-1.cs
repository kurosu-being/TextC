using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Practice10_5_1 {
    //Practice10-5-1 HTMLファイルを読み込み、<DIV>や<P>などのタグ名が大文字になっているものを<div>,<p>などと小文字のタグに変換してください。可能ならば、<DIC class="myBox" id="myId">というように
    //属性が記述されて切る場合にも対応してください。属性の中には'<','>'は含まれていないものとします。
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("HTMLファイルを読み込んでください。");
            var wFilePath = Console.ReadLine();
            if (string.IsNullOrEmpty(wFilePath)) {
                Console.WriteLine("入力が空です");
                return;
            }

            if (!File.Exists(wFilePath)) {
                Console.WriteLine("ファイルが存在しません。パスが正しいか確認してください");
                return;
            }

            string wHtmlContent = File.ReadAllText(wFilePath);

            var wModifiedHtmlContent = Regex.Replace(wHtmlContent, @"<[^>]+>", match => {
                string wTag = match.Value.ToLower();
                wTag = Regex.Replace(wTag, @"(\w+)(?=\s*=)", attribute => attribute.Value.ToLower());
                return wTag;
            });

            Console.WriteLine("HTMLファイルの書き換えが完了しました");
        }
    }
}
