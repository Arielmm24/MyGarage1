using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using MyGarage1.Classes;

namespace MyGarage1.Classes
{
    public class Connect
    {
        private OleDbConnection cn;
        private string conStr;
        public Connect()
        {
        }
        const string FILE_NAME = "mygarage_db";
        
        public static string getConnectionString()
        {

            //string myConnectionString = "server=127.0.0.1;uid=root;pwd=;database=" + FILE_NAME + @"; Provider=Microsoft.Jet.OLEDB.4.0;";
            string myConnectionString = "Data Source=127.0.0.1,3306;Initial Catalog=אריאל;User ID=root;Password=";
            //string myConnectionString = "Server=127.0.0.1;Database=" + FILE_NAME + ";Uid=root;Pwd=;";
            return myConnectionString;
        }
        public bool NonQuery(string sqlString)
        {
            this.cn.Open();
            OleDbCommand cmd = new OleDbCommand(sqlString, this.cn);
            int a = cmd.ExecuteNonQuery();
            if (a != 0)
                return true;
            return false;
        }

        public void UpdateDataBase(DataSet ds, string sql)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, cn);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.UpdateCommand = builder.GetUpdateCommand();
            adapter.Update(ds.Tables[0]);
        }
        public OleDbDataReader GetReader(string sqlString)
        {
            cn.Open();
            OleDbCommand cmd = new OleDbCommand(sqlString, this.cn);
            OleDbDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public void CloseCon()
        {
            cn.Close();
        }

        public void OpenCon()
        {
            cn.Open();
        }
    }
}