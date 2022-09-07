using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace MyGarage1.Classes
{
    public class DataService
    {

        //protected OleDbConnection myConnection;
        protected SqlConnection myConnection;
        protected OleDbDataAdapter adapter;
        protected OleDbDataAdapter adapterWords;
        
        public DataService()
        {
            string connectionString = Connect.getConnectionString();
            //myConnection = new OleDbConnection(connectionString);
            myConnection = new SqlConnection(connectionString);
            /*string sSql = "select * from kinds";
            adapter = new OleDbDataAdapter(sSql, connectionString);
            sSql = "select * from wordsTbl";
            adapterWords = new OleDbDataAdapter(sSql, connectionString);*/

        }
        //public string AddDetails(string userName, string passWord, string name, string email)
        //{

        //    string sSql = "INSERT INTO logintbl VALUES ('" + userName + "','" + passWord + "','" + name + "','" + email + "','" + "',false)";
        //    OleDbCommand cmd = new OleDbCommand(sSql, myConnection);
        //    object obj = null;
        //    try
        //    {
        //        myConnection.Open();
        //        obj = cmd.ExecuteScalar();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        myConnection.Close();
        //    }
        //    if (obj == null)
        //        return string.Empty;
        //    else
        //        return obj.ToString();
        //}
        public bool LoginU(string username)
        {
            string sSql = "SELECT * FROM logintbl Where Username='" + username + "'";
            SqlCommand cmd = new SqlCommand(sSql, myConnection);
            object obj = null;

            try
            {
                myConnection.Open();
                //obj = cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }
            return (obj != null);
        }
        //public bool LoginP(string password, string username)
        //{
        //    string sSql = "SELECT Password FROM logintbl Where Username='" + username + "'";
        //    OleDbCommand cmd = new OleDbCommand(sSql, myConnection);
        //    object obj = null;
        //    int k;
        //    try
        //    {
        //        myConnection.Open();
        //        obj = cmd.ExecuteScalar();
        //        k = password.CompareTo(obj.ToString());

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        myConnection.Close();
        //    }
        //    if (k == 0)
        //    {
        //        return true;
        //    }
        //    else
        //        return false;
        //}
        //public user getUser(string username, string password)
        //{
        //    string sSql = "SELECT * FROM loginTbl Where user='" + username + "' AND password='" + password + "'";
        //    OleDbCommand cmd = new OleDbCommand(sSql, myConnection);
        //    OleDbDataReader dr;
        //    user u1;
        //    try
        //    {
        //        myConnection.Open();
        //        dr = cmd.ExecuteReader();
        //        dr.Read();
        //        u1 = new user(dr["user"].ToString(), dr["password"].ToString(), dr["name"].ToString(), dr["Email"].ToString());
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        myConnection.Close();
        //    }


        //    return u1;
        //}
        //public DataSet GetDataSet(string sql, string tablename)
        //{
        //    DataSet ds = new DataSet();
        //    myConnection.Open();
        //    try
        //    {
        //        OleDbDataAdapter adapter = new OleDbDataAdapter(sql, myConnection);
        //        adapter.Fill(ds, tablename);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        myConnection.Close();
        //    }
        //    return ds;
        //}

        //public bool NonQuery(string sqlString)
        //{
        //    myConnection.Open();
        //    OleDbCommand cmd = new OleDbCommand(sqlString, myConnection);
        //    int a = cmd.ExecuteNonQuery();
        //    if (a != 0)
        //        return true;
        //    return false;
        //}
        //public void DeleteUser(string username)
        //{
        //    string cmd = "DELETE FROM loginTbl WHERE user ='" + username + "'";
        //    OleDbCommand command = new OleDbCommand(cmd, myConnection);
        //    try
        //    {
        //        myConnection.Open();
        //        command.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        myConnection.Close();
        //    }
        //}
        //public user EditProfile(user u1, string pw, string name, string email)
        //{
        //    string sSql = "UPDATE loginTbl SET [password] = '" + pw + "', [name] = '" + name + "', email = '" + email + "' WHERE user='" + u1.username + "'";
        //    OleDbCommand cmd = new OleDbCommand(sSql, myConnection);
        //    user newuser = null;
        //    try
        //    {
        //        myConnection.Open();
        //        cmd.ExecuteNonQuery();
        //        newuser = new user(u1.username, pw, name, email);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        myConnection.Close();
        //    }
        //    return newuser;
        //}
    }

}
