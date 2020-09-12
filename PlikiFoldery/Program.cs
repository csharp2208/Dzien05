using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlikiFoldery
{
    class Program
    {

        // CopyDir(@"c:\tmp\copy1", @"c:\tmp\copy2\");
        static void CopyDir(string sourceDir, string targetDir)
        {
            if (!sourceDir.EndsWith(@"\")) {
                sourceDir += @"\";
            }
            if (!targetDir.EndsWith(@"\"))
            {
                targetDir += @"\";
            }

            if (!Directory.Exists(targetDir))
            {
                Directory.CreateDirectory(targetDir);
            }

            string[] files = Directory.GetFileSystemEntries(sourceDir);
            for (int i = 0; i < files.Length; i++)
            {
                String srcFile = files[i];
                Console.WriteLine(srcFile);
                FileAttributes attr = File.GetAttributes(srcFile);
                if (attr==FileAttributes.Directory)
                {
                    // natrafilismy za folder
                    // rekurencyjna obsluga kopiowania folderow
                    String newFolder = targetDir + Path.GetFileName(srcFile);
                    CopyDir(srcFile, newFolder);

                } else
                {
                    //kopiowanie pliku
                    File.Copy(srcFile, targetDir + Path.GetFileName(srcFile), true);
                }
            }

        }

        static void Main(string[] args)
        {
            CopyDir(@"C:\tmp\copy1", @"C:\tmp\copy2");

            String s = Directory.GetCurrentDirectory();
            Console.WriteLine(s);
            if (!Directory.Exists(@"c:\tmp\alx1"))
            {
                Directory.CreateDirectory(@"c:\tmp\alx1");
            }
            Directory.Move(@"c:\tmp\alx1", @"c:\tmp\alx2");
            Directory.Delete(@"c:\tmp\alx2", true);

            // kilka operacji na plikach
            File.WriteAllText(@"c:\tmp\ala.txt", "Ala ma kota, a kot ma kleszcze");
            s = File.ReadAllText(@"c:\tmp\ala.txt");

            File.Copy(@"c:\tmp\ala.txt", @"c:\tmp\kot.txt", true);
            if (File.Exists(@"c:\tmp\kleszcz.txt"))
            {
                File.Delete(@"c:\tmp\kleszcz.txt");
            }
            File.Move(@"c:\tmp\kot.txt", @"c:\tmp\kleszcz.txt");
            
            Console.WriteLine(s);
            
            Console.ReadKey();
        }
    }
}
