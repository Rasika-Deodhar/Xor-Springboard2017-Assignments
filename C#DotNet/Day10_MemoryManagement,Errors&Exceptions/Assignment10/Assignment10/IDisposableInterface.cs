using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    class IDisposableInterface : IDisposable
    {
        public static string FileName = @"D:\Assignments_and_Notes\C#\22Aug_MemoryMgmt\TextFile.txt";
        public static FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate);
        public static StreamWriter writer = new StreamWriter(fs);
        public static StreamReader reader = new StreamReader(fs);

        public void Dispose()
        {
            Dispose(true);
        }

        private void Dispose(bool v)
        {
            if(v)
            {
                GC.SuppressFinalize(this);
            }
            if (writer != null)
            {
                writer.Dispose();
                Console.WriteLine("Writer Disposed!");
            }
            if (reader != null)
            {
                reader.Dispose();
                Console.WriteLine("Reader Disposed!");
            }
        }

        public void StreamFile()
        {
            
            writer.WriteLine("Hello! This is my first File Created!");
            writer.WriteLine("We have to create IDisposable class after this.");
            //writer.Flush();

            
            Console.WriteLine("Reading From File.");
            string read;
            while ((read = reader.ReadLine()) != null)
            {
                Console.WriteLine(read);
            }
            
        }
    }
}
