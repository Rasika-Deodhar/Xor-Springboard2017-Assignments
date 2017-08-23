using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AdoDotNet
{
    public class SqlHelper
    {
        private SqlConnection _sqlConnection;
        private SqlCommand _sqlCommand;
        private SqlDataAdapter _sqlDataAdapter;
        public string sqlQuery = null;
        public string conString = @"Data Source=.\SQLEXPRESS;Initial Catalog=DemoStudent;Integrated Security=True;Pooling=False"; //Integrated Security =>True= Windows Authenticity; 

        public SqlHelper()
        {
            _sqlConnection = new SqlConnection(conString);

            if(_sqlConnection.State==System.Data.ConnectionState.Closed)
            _sqlConnection.Open();

            Console.WriteLine("Connection is Opened.");
        }

        public SqlDataReader ExecuteQuery(string sqlQuery)
        {
            _sqlCommand = new SqlCommand(sqlQuery,_sqlConnection);

            //Second method to execute query
            //_sqlCommand.CommandText = sqlQuery;
            //_sqlCommand.Connection = _sqlConnection;

            return _sqlCommand.ExecuteReader();
        }

        public string ExecuteScalar(string sqlQuery)
        {
            _sqlCommand = new SqlCommand(sqlQuery, _sqlConnection);
            return _sqlCommand.ExecuteScalar().ToString();
        }

        public bool ExecuteNonQuery(string sqlQuery)
        {
            var result = false;
            _sqlCommand = new SqlCommand(sqlQuery, _sqlConnection);
            var count = _sqlCommand.ExecuteNonQuery();
            result = count > 0 ? true : false;
            return result;
        }

        public DataTable GetDataSet(string sqlQuery)
        {
            var dataSet = new DataSet();
            _sqlDataAdapter = new SqlDataAdapter(sqlQuery, conString);
            _sqlDataAdapter.Fill(dataSet, "student");
            return dataSet.Tables[0];
        }

        public DataTable GetDataTable(string sqlQuery)
        {
            var dataTable = new DataTable();
            _sqlDataAdapter = new SqlDataAdapter(sqlQuery, conString);
            _sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable update(int id, string sname)
        {
            sqlQuery = string.Format("select * from [table] where Id={0}",id);
            var dataSet = new DataSet();
            _sqlDataAdapter = new SqlDataAdapter(sqlQuery, conString);

            SqlCommandBuilder scb = new SqlCommandBuilder(_sqlDataAdapter);
            _sqlDataAdapter.Fill(dataSet, "student");
            DataTable dataTable = dataSet.Tables[0];

            dataTable.Rows[0][0] = id;
            dataTable.Rows[0][1] = sname;
            _sqlDataAdapter.Update(dataTable);

            return dataTable;
        }

        public DataTable delete(int id)
        {
            sqlQuery = string.Format("select * from [table] where Id={0}", id);

            var dataSet = new DataSet();
            _sqlDataAdapter = new SqlDataAdapter(sqlQuery, conString);

            SqlCommandBuilder scb = new SqlCommandBuilder(_sqlDataAdapter);
            _sqlDataAdapter.Fill(dataSet, "student");

            DataTable dataTable = dataSet.Tables[0];
            foreach (DataRow row in dataTable.Rows)
            {
                row.Delete();
            }

            _sqlDataAdapter.Update(dataTable);

            return dataTable;
        }
    }
}
