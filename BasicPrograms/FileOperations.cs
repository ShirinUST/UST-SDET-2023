using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class FileOperations
    {
        public void CreateFile()
        {
            FileInfo fileInfo = new FileInfo("D:\\Sample\\Sample.txt");
            using StreamWriter str=fileInfo.CreateText();
            Console.WriteLine("File has been created");
            str.WriteLine("Hi Im here");
            str.WriteLine("Helloooo");
            Console.WriteLine("Written");
        }
        public void WriteFile()
        {
            FileStream file = new FileStream("D:\\Sample\\Sample2.txt",FileMode.Append,FileAccess.Write);
            StreamWriter sw=new StreamWriter(file);
            Console.WriteLine("Enter text:");
            string? txt=Console.ReadLine();
            sw.WriteLine(txt);
            sw.Flush();
            sw.Close();
            file.Close();
        }

        public void ReadData()
        {
            FileStream fs=new FileStream("D:\\Sample\\Sample2.txt",FileMode.Open,FileAccess.Read);
            StreamReader sr=new StreamReader(fs);
            //string? txt=sr.ReadToEnd();
            //Console.WriteLine(txt);
            sr.BaseStream.Seek(0,SeekOrigin.Begin);
            string? txt = sr.ReadLine();
            while (txt != null)
            {
                Console.WriteLine(txt);
                txt = sr.ReadLine();
            }
            sr.Close();
        }
        public void CopyMoveFile()
        {
            FileInfo file1 = new FileInfo("D:\\Sample\\Sample.txt");
            FileInfo file2 = new FileInfo("D:\\Sample\\Sample2.txt");

            file1.CopyTo("D:\\Sample\\Temp\\temp.txt");
            file2.MoveTo("D:\\Sample\\Temp\\aa.txt");
        }
        public void DeleteFile()
        {
            FileInfo file1 = new FileInfo("D:\\Sample\\Temp\\temp.txt");
            file1.Delete();
            Console.WriteLine("Deleted");
        }
        public void FileProperties()
        {
            FileInfo file2 = new FileInfo("D:\\Sample\\Sample2.txt");
            Console.WriteLine(file2.Name);
            Console.WriteLine(file2.FullName);
            Console.WriteLine(file2.CreationTime);
            Console.WriteLine(file2.Length);
            Console.WriteLine(file2.LastAccessTime);
            Console.WriteLine(file2.LastWriteTime);
            Console.WriteLine(file2.Extension);
            Console.WriteLine(file2.Exists);
        }
    }
}
