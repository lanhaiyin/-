using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace dal
{
    public class sjk
    {
        SqlConnection jianli = new SqlConnection();
        SqlCommand diaoyong = new SqlCommand();
        SqlDataAdapter tianchong = new SqlDataAdapter();

        public DataTable Select(string strCmd)
        {
            DataTable dtTemp = new DataTable();
            try
            {
                jianli.Open();
                diaoyong.Connection = jianli;
                diaoyong.CommandText = strCmd;
                tianchong.SelectCommand = diaoyong;
                tianchong.Fill(dtTemp);
                diaoyong.Parameters.Clear();
                return dtTemp;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL语句错误，请检查SQL语句！");
                return dtTemp;
            }
            finally
            {
                jianli.Close();
            }
        }

        public SqlDataReader Select2(string strCmd)
        {
            SqlDataReader dtTemp;
            jianli.Open();
            diaoyong.Connection = jianli;
            diaoyong.CommandText = strCmd;
            dtTemp = diaoyong.ExecuteReader();
            diaoyong.Parameters.Clear();
            return dtTemp;
        }

        public void close()
        {
            jianli.Close();
        }

        public void AddParameters(string str, SqlDbType type, object value)
        {
            diaoyong.Parameters.Add(str, type).Value = value;
        }

        public void clear()
        {
            diaoyong.Parameters.Clear();
        }
        public void Update(string strCmd)
        {
            try
            {
                jianli.Open();
                diaoyong.Connection = jianli;
                diaoyong.CommandText = strCmd;
                diaoyong.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL语句错误，请检查SQL语句！");
            }
            finally
            {
                diaoyong.Parameters.Clear();
                jianli.Close();
            }
        }
        public bool Up(string strCmd)
        {
            try
            {
                jianli.Open();
                diaoyong.Connection = jianli;
                diaoyong.CommandText = strCmd;
                diaoyong.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                return false;
            }
            finally
            {
                jianli.Close();
            }
        }
        public void Insert(string strCmd)
        {
            try
            {
                jianli.Open();
                diaoyong.Connection = jianli;
                diaoyong.CommandText = strCmd;
                diaoyong.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL语句错误，请检查SQL语句！");
            }
            finally
            {
                diaoyong.Parameters.Clear();
                jianli.Close();
            }
        }
        public void Delete(string strCmd)
        {
            try
            {
                jianli.Open();
                diaoyong.Connection = jianli;
                diaoyong.CommandText = strCmd;
                diaoyong.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL语句错误，请检查SQL语句！");
            }
            finally
            {
                diaoyong.Parameters.Clear();
                jianli.Close();
            }
        }

        //构造函数
        public sjk()
        {
            jianli.ConnectionString = "server=.;database=cangku;uid=sa;pwd=123";
        }
    }
}
