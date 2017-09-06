using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    class UsingBlock
    {
        public static string FileName = @"D:\Assignments_and_Notes\C#\22Aug_MemoryMgmt\TextFile.txt";
        FileStream fs = null;

        public void usingBlock()
        {
            fs = new FileStream(FileName, FileMode.Open,FileAccess.ReadWrite);
            
            using (StreamWriter writer = new StreamWriter(fs))
            {
                fs.Seek(fs.Length, SeekOrigin.Begin);
                writer.WriteLine("Appending the File from below!!");
                //writer.Close();
                //fs.Close();
            }
            using (StreamReader reader = new StreamReader(new FileStream(@"D:\Assignments_and_Notes\C#\22Aug_MemoryMgmt\TextFile.txt", FileMode.Open, FileAccess.Read)))
            {
                Console.WriteLine("Reading From File.");
                string read;
                while ((read = reader.ReadLine()) != null)
                {
                    Console.WriteLine(read);
                }
            }
        }
    }
}
