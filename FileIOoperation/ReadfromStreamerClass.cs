using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileIOoperation
{
    public class ReadfromStreamerClass
    {
        public static void Read()
        {
            String path = @"E:\BridgeLAbz\demo\FileIOoperation\utility\Sample.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                String s = "";
                while((s=sr.ReadLine())!= null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();
        }

        public static void Write()
        {
            String path = @"E:\BridgeLAbz\demo\FileIOoperation\utility\Sample.txt";
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("annotations garbage-collection methods");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
            Console.ReadKey();
        }
    }
}
