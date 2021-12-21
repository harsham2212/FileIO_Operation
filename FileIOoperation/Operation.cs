using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileIOoperation
{
    class Operation
    {
        public static void FileExists()
        {
            String path = @"E:\BridgeLAbz\demo\FileIOoperation\utility\Sample.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("Hey!File Exists");
            }
            else
            {
                Console.WriteLine("Sorry!File Does not Exits");
            }
            Console.ReadKey();
        }


        public static void ReadAllLines()
        {
            String path = @"E:\BridgeLAbz\demo\FileIOoperation\utility\Sample.txt";
            String[] lines;
            lines = File.ReadAllLines(path);

            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);

            Console.ReadKey();
        }


        public static void ReadAllText()
        {
            String path = @"E:\BridgeLAbz\demo\FileIOoperation\utility\Sample.txt";
            String lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);
            Console.ReadKey();
        }


        public static void FileCopy()
        {
            String path = @"E:\BridgeLAbz\demo\FileIOoperation\utility\Sample.txt";
            String copypath = @"E:\BridgeLAbz\demo\FileIOoperation\utility\NewSample.txt";
            File.Copy(path, copypath);
            Console.WriteLine("NewSample has been created into desired folder");
            Console.ReadKey();
        }


        public static void DeleteFile()
        {
            String path= @"E:\BridgeLAbz\demo\FileIOoperation\utility\NewSample.txt";
            File.Delete(path);
            Console.WriteLine("NewSample has been deleted into desired folder");
            Console.ReadKey();
        }
    }
}