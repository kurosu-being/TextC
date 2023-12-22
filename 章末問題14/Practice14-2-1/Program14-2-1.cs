using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Practice14_2_1 {
    //Practice14-2-1 自分自身のファイルバージョンとアッセンブリバージョンを表示するコンソールアプリケーションを作成してください。
    class Program {
        static void Main(string[] args) {
            var wAssembly = Assembly.GetExecutingAssembly();
            var wAssemblyVersion = wAssembly.GetName().Version;
            var wFileVersion = FileVersionInfo.GetVersionInfo(wAssembly.Location);
            Console.WriteLine($"{wFileVersion.FileMajorPart}{wFileVersion.FileMinorPart}{wFileVersion.FileBuildPart}{wFileVersion.FilePrivatePart}{Environment.NewLine}{wAssemblyVersion.Major}.{wAssemblyVersion.Minor}.{wAssemblyVersion.Build}.{wAssemblyVersion.Revision}");
        }
    }
}
