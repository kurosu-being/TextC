using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Practice10_5_1 {
    //Practice10-5-1 HTMLファイルを読み込み、<DIV>や<P>などのタグ名が大文字になっているものを<div>,<p>などと小文字のタグに変換してください。可能ならば、<DIC class="myBox" id="myId">というように
    //属性が記述されて切る場合にも対応してください。属性の中には'<','>'は含まれていないものとします。
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("HTMLファイルを読み込んでください。サンプルのHTMLファイルはチケットに貼ってあります。");
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
            string wModifiedHtmlContent = ConvertToLowerHTML(wHtmlContent);

            try {
                File.WriteAllText(wFilePath, wModifiedHtmlContent);
                Console.WriteLine("ファイルの書き込みが完了しました");
            } catch (Exception wEx) {
                Console.WriteLine("ファイルの書き込み中にエラーが発生しました: " + wEx.Message);
            }
        }

        /// <summary>
        /// 属性のタグを小文字にするメソッド
        /// </summary>
        /// <param name="vHtmlContent">HTMLの原文</param>
        /// <returns> 属性のタグを小文字にしたテキスト</returns>
        static string ConvertToLowerHTML(string vHtmlContent) {
            string wModifiedContent = Regex.Replace(vHtmlContent, @"<[^>]+>", match => {
                string wTag = match.Value.ToLower();
                wTag = Regex.Replace(wTag, @"(\w+)(?=\s*=)", x => x.Value.ToLower());
                return wTag;
            });
            return wModifiedContent;
        }
    }
}
