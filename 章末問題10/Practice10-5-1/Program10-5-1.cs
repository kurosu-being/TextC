using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Practice10_5_1 {
    //Practice10-5-1 HTMLファイルを読み込み、<DIV>や<P>などのタグ名が大文字になっているものを<div>,<p>などと小文字のタグに変換してください。可能ならば、<DIC class="myBox" id="myId">というように
    //属性が記述されて切る場合にも対応してください。属性の中には'<','>'は含まれていないものとします。
    class Program {
        static void Main(string[] args) {
            // HTMLファイルを読み込む
            Console.WriteLine("HTMLファイルを読み込んでください。v");
            var wFilePath = Console.ReadLine();
            if (!File.Exists(wFilePath)) {
                Console.WriteLine("ファイルが存在しません。パスが正しいか確認してください");
            }
            if (string.IsNullOrEmpty(wFilePath)) {
                Console.WriteLine("パスが空です");
            }

            string wHtmlContent = File.ReadAllText(wFilePath);
            string[] wLines = wHtmlContent.Split('\n'); // HTMLを行ごとに分割

            for (int i = 0; i < wLines.Length; i++) {
                string wLine = wLines[i];

                // 正規表現を使ってタグを小文字に変換
                string wModifiedLine = Regex.Replace(wLine, @"<[^>]+>", x =>
                {
                    string wTag = x.Value.ToLower();
                    wTag = Regex.Replace(wTag, @"(\w+)(?=\s*=)", tag => tag.Value.ToLower());
                    return wTag;
                });

                wLines[i] = wModifiedLine; // 変更した行を再度配列に格納
            }

            // 変更した各行を結合してHTMLを再構築
            string wModifiedHTML = string.Join("\n", wLines);
            Console.WriteLine("書き換えが完了しました");
        }
    }
}
