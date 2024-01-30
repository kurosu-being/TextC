using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

class Program
/*Practice16-2-1 指定したディレクトリにあるC#のソースファイル（サブディレクトリを含む）の中を全て検索し、
キーワードasyncとawaitの両方を利用しているファイルを列挙してください。列挙する場合は、ファイルのフルパスを表示してください。表示する順番は問いません。
　　並列処理した場合と、並列処理しない場合の2つのバージョンを作成し、どれくらい速度に差があるかも調べてください。*/
{
    static void Main() {
        Console.WriteLine($"指定したディレクトリにあるC#のソースファイル(サブディレクトリを含む）の中を全て検索し、{Environment.NewLine}キーワードasyncとawaitの両方を利用しているファイルを列挙します。{Environment.NewLine}ディレクトリパスを入力して下さい。");
        string wDirectoryPath = Console.ReadLine();

        if (!Directory.Exists(wDirectoryPath)) {
            Console.WriteLine("ディレクトリが見つかりませんでした。パスが正しく入力されているか確認してください。");
            return;
        }

        Console.WriteLine("非並列処理の場合:");
        SearchFiles(wDirectoryPath, false);

        Console.WriteLine($"{Environment.NewLine}並列処理の場合:");
        SearchFiles(wDirectoryPath, true);
    }

    static async Task<string> ReadAllTextAsync(string vPath) {
        using (var wReader = new StreamReader(vPath)) {
            return await wReader.ReadToEndAsync();
        }
    }

    static void SearchFiles(string vDirectoryPath, bool vParallel) {
        var wFilesWithAsyncAwaits = new List<string>();
        Stopwatch wStopwatch = new Stopwatch();

        wStopwatch.Start();

        if (vParallel) {
            wFilesWithAsyncAwaits = Directory.GetFiles(vDirectoryPath, "*.cs", SearchOption.AllDirectories)
                .AsParallel()
                .Where(x => ContainsAsyncAwait(x))
                .ToList();
        } else {
            wFilesWithAsyncAwaits = Directory.GetFiles(vDirectoryPath, "*.cs", SearchOption.AllDirectories)
                .Where(x => ContainsAsyncAwait(x))
                .ToList();
        }

        wStopwatch.Stop();

        foreach (var wFile in wFilesWithAsyncAwaits) {
            Console.WriteLine(wFile);
        }

        Console.WriteLine($"処理時間: {wStopwatch.ElapsedMilliseconds} ミリ秒");
    }

    static bool ContainsAsyncAwait(string vFilePath) {
        try {
            string wContent = ReadAllTextAsync(vFilePath).Result;
            return wContent.Contains("async") && wContent.Contains("await");

        } catch (UnauthorizedAccessException ex) {
            Console.WriteLine($"アクセス権限がありません: {ex.Message}");
            return false;
        } catch (IOException ex) {
            Console.WriteLine($"I/Oエラーが発生しました: {ex.Message}");
            return false;
        } catch (Exception ex) {
            Console.WriteLine($"エラーが発生しました: {ex.Message}");
            return false;
        }
    }
}
