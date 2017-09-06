using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AdoDotNet
{
    public class Student
    {
        public SqlHelper sqlHelper;
        public string sqlQuery,sqlQuery1;

        public Student()
        {
            sqlHelper = new SqlHelper();
        }

        public void GetData()
        {
            sqlQuery = "select * from [table]";
            sqlQuery1 = "select count(*) from [table]";

            var sqlReader = sqlHelper.ExecuteQuery(sqlQuery);

            while (sqlReader.Read())
            {
                Console.WriteLine(string.Format("Roll No:{0} , Name:{1} , Marks:{2} , Contact:{3}",sqlReader[0],sqlReader[1], sqlReader[2], sqlReader[3]));
            }
            //Can also use sqlReader.hasRows and then increment by sqlReader.next in a while loop

            sqlReader.Close();

            var sqlReader1 = sqlHelper.ExecuteScalar(sqlQuery1); // will not work if sqlReader is not closed
            //using ExecuteScalar for single valued queries
            Console.WriteLine("Count = " + sqlReader1);
        
        }

        public void SaveData()
        {
            Console.WriteLine("Enter new Roll Number - ");
            int id = Convert.ToInt32(Console.Read());

            sqlQuery = string.Format(@"insert into [Table] values ({0},'{1}','{2}','{3}')", id, "Saina", "82", "564565756");

            var sqlReader2 = sqlHelper.ExecuteNonQuery(sqlQuery);
        }

        public void GetDataSet()
        {
            sqlQuery = "select * from [table]";

            DataTable dataTable = sqlHelper.GetDataSet(sqlQuery);
            DataTable dataTable1 = sqlHelper.GetDataTable(sqlQuery);

            Console.WriteLine("Data Set-");
            foreach (DataRow dr in dataTable.Rows)
            {
                Console.WriteLine(string.Format("Roll No:{0} , Name:{1} , Marks:{2} , Contact:{3}", 
                    dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString()));
            }

            Console.WriteLine("Data Table-");
            foreach (DataRow dr in dataTable1.Rows)
            {
                Console.WriteLine(string.Format("Roll No:{0} , Name:{1} , Marks:{2} , Contact:{3}",
                    dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString()));
            }
            
            dataTable.WriteXml("StudentData.xls"); // creates xml file in bin folder of the project directory
        }

        public void getUpdate()
        {
            Console.WriteLine("Enter roll no to update = ");
            int uId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter new name = ");
            string newName = Console.ReadLine();

            var updatedData=sqlHelper.update(uId,newName);

            Console.WriteLine("Updated Data-");

            foreach (DataRow dr in updatedData.Rows)
            {
                Console.WriteLine(string.Format("Roll No:{0} , Name:{1} , Marks:{2} , Contact:{3}",
                    dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString()));
            }
        }

        public void deleteRecord()
        {
            Console.WriteLine("Enter Roll no to Delete = ");
            int deleteId = Convert.ToInt32(Console.ReadLine());

            var deletedData = sqlHelper.delete(deleteId);

            foreach (DataRow dr in deletedData.Rows)
            {
                Console.WriteLine(string.Format("Roll No:{0} , Name:{1} , Marks:{2} , Contact:{3}",
                    dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString()));
            }
        }

    }
}
