﻿using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Practice11_1_2 {
    //Practice11-1-2 最初にプレーされた年の若い順に漢字の表記名を表示してください。
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("XMLファイルのパスを入力してください。");
            var wInputFile = Console.ReadLine();
            if (!File.Exists(wInputFile)) {
                Console.WriteLine("ファイルが存在しません。パスが正しいか確認してください。");
            }

            Console.WriteLine("最初にプレーされた年の若い順に漢字の表記名を表示します");

            var wXdocument = XDocument.Load(wInputFile);
            var wXSortkanjiNames = wXdocument.Root.Elements().OrderBy(x => (int)x.Element("firstplayed"));
            foreach (var wGameName in wXSortkanjiNames) {
                var wXname = wGameName.Element("name");
                XAttribute wXAttribute = wXname.Attribute("kanji");
                Console.WriteLine($"漢字表記名「{wXAttribute?.Value}」");
            }
        }
    }
}
