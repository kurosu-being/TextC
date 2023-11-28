using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Practice10_5_1 {
    //Practice10-5-1 HTMLファイルを読み込み、<DIV>や<P>などのタグ名が大文字になっているものを<div>,<p>などと小文字のタグに変換してください。可能ならば、<DIC class="myBox" id="myId">というように
    //属性が記述されて切る場合にも対応してください。属性の中には'<','>'は含まれていないものとします。
    class Program {
        static void Main(string[] args) {
            // HTMLファイルを読み込む
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
            string[] wLines = wHtmlContent.Split('\n');

            for (int i = 0; i < wLines.Length; i++) {
                string wLine = wLines[i];

                string wModifiedLine = Regex.Replace(wLine, @"<[^>]+>", x =>
                {
                    string wTag = x.Value.ToLower();
                    wTag = Regex.Replace(wTag, @"(\w+)(?=\s*=)", tag => tag.Value.ToLower());
                    return wTag;
                });

                wLines[i] = wModifiedLine;
            }

            string wModifiedHTML = string.Join("\n", wLines);
            Console.WriteLine("書き換えが完了しました");
        }
    }
}
