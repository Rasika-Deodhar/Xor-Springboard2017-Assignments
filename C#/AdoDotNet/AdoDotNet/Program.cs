using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdoDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var student = new Student();
                //student.GetData();
                //student.SaveData();
                student.GetDataSet();
                //student.getUpdate();
                //student.GetData();
                student.deleteRecord();
                student.GetData();

                Console.Read();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
