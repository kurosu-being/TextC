using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice16_1_1 {
    //Practice16-1-1 ReadLinesAsyncメソッドを使って、テキストファイルを非同期で読み込むコードを書いてください。
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private async void button1_ClickAsync(object sender, EventArgs e) {

            try {
                string wFilePath = InputTextBox.Text.Trim();

                // ファイルが存在するか確認
                if (!File.Exists(wFilePath)) {
                    MessageBox.Show("ファイルが見つかりません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Path.GetExtension(wFilePath) != ".txt") {
                    MessageBox.Show("txtファイルではありません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // ファイルを非同期で読み込む
                await ReadFileAsync(wFilePath);

                MessageBox.Show("ファイルの読み込みが完了しました。", "成功！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (UnauthorizedAccessException ex) {
                Console.WriteLine($"アクセス権限がありません: {ex.Message}");
            } catch (IOException ex) {
                Console.WriteLine($"I/Oエラーが発生しました: {ex.Message}");
            } catch (Exception ex) {
                Console.WriteLine($"エラーが発生しました: {ex.Message}");
            }

        }
        private async Task ReadFileAsync(string filePath) {
            using (var wStreamReader = new StreamReader(filePath)) {
                // ファイルを非同期で行ごとに読み込む
                while (!wStreamReader.EndOfStream) {
                    string wLine = await wStreamReader.ReadLineAsync();
                    listBox1.Invoke((Action)delegate { listBox1.Items.Add(wLine); });
                }
            }
        }
    }
}
