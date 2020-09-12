﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strumienie
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(@"c:\tmp\test.txt");
                sw.AutoFlush = true;
                for (int i = 1; i <=10; i++)
                {
                    sw.WriteLine($"Linia nr {i}");
                }
            } catch (IOException exc)
            {
                Console.WriteLine(exc.Message);
            } finally
            {
                if (sw!=null) sw.Close();
            }

            // C# 3.0 - resource manager
            try
            {
                using (StreamWriter sw1 = new StreamWriter(@"c:\tmp\test1.txt"))
                {
                    sw1.Write("ABCDEFGH");
                }
            } catch (IOException exc)
            {
                Console.WriteLine(exc.Message);
            }


            // odczyt ze strumienia (z pliku)
            String path = @"c:\tmp\test.txt";
            if (File.Exists(path))
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, (int)fs.Length);
                fs.Close();

                String s = Encoding.UTF8.GetString(data);
                Console.WriteLine(s);

            } else
            {
                Console.WriteLine("plik nie istnieje");
            }

            // odczyt pliku txt linia po linii
            StreamReader sr = new StreamReader(path);
            String line = null;
            String result = "";
            StringBuilder sb = new StringBuilder();
            do
            {
                line = sr.ReadLine();
                //result += line + Environment.NewLine; // "\r\n";
                //Console.WriteLine(line);
                sb.AppendLine(line);
            } while (line != null);
            sr.Close();
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}
