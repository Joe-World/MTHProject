﻿using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

using System.Configuration;

namespace wgd.MTHDAL
{
    /// <summary>
    /// 基础通用数据访问类
    /// </summary>
    class SQLHelper
    {
        //读取配置文件获得连接字符串
        /*private static string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();*/
        private static string connString = "server=localhost;database=MultiTHMonitorDB;uid=sa;password=123456;";


        /// <summary>
        /// 执行insert、update、delete类型的SQL语句
        /// </summary>
        /// <param name="cmdText">SQL语句或存储过程名称</param>
        /// <param name="paramArray">参数数组</param>
        /// <returns>受影响的行数</returns>
        public static int ExecuteNonQuery(string cmdText, SqlParameter[] paramArray = null)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            if (paramArray != null)
            {
                cmd.Parameters.AddRange(paramArray);
            }
            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string errorMsg = $"{DateTime.Now}  : 执行 public static int ExecuteNonQuery(string cmdText, SqlParameter[] paramArray = null)方法发生异常：{ ex.Message}";
                //在这个地方写入日志...


                throw new Exception("执行public static int ExecuteNonQuery(string cmdText, SqlParameter[] paramArray = null)方法发生异常：" + ex.Message);
            }
            finally   //以上不管是否发生异常，都会执行的代码
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 返回单一结果的查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string cmdText, SqlParameter[] paramArray = null)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            if (paramArray != null)
            {
                cmd.Parameters.AddRange(paramArray);
            }
            try
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //在这个地方写入日志...

                throw new Exception("执行 public object ExecuteScalar(string cmdText, SqlParameter[] paramArray = null方法发生异常：" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 执行返回一个只读结果集的查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string cmdText, SqlParameter[] paramArray = null)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            if (paramArray != null)
            {
                cmd.Parameters.AddRange(paramArray);
            }
            try
            {
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection); //必须添加这个枚举
            }
            catch (Exception ex)
            {
                //在这个地方写入日志...

                throw new Exception("执行 public object SqlDataReader(string cmdText, SqlParameter[] paramArray = null)方法发生异常：" + ex.Message);
            }
        }
        /// <summary>
        /// 返回包含一张数据表的数据集的查询
        /// </summary>
        /// <param name="sql">查询语句</param>
        /// <param name="tableName">数据表的名称</param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql, string tableName = null)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                if (tableName == null)
                    da.Fill(ds);
                else
                    da.Fill(ds, tableName);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("执行 public DataSet GetDataSet(string sql, string tableName = null)方法发生异常：" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataSet GetDataSet(string sql, SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    try
                    {
                        connection.Open();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataSet dataSet = new DataSet();
                            adapter.Fill(dataSet);
                            return dataSet;
                        }
                    }
                    catch (SqlException ex)
                    {
                        // 处理数据库异常，这里可以记录日志或抛出异常  
                        Console.WriteLine("数据库查询异常: " + ex.Message);
                        return null;
                    }
                    catch (Exception ex)
                    {
                        // 处理其他异常，这里可以记录日志或抛出异常  
                        Console.WriteLine("异常: " + ex.Message);
                        return null;
                    }
                }
            }
        }

        /// <summary>
        /// 执行查询，返回一个或多个表的DataSet
        /// </summary>
        /// <param name="dicTableAndSql"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(Dictionary<string, string> dicTableAndSql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                foreach (string tbName in dicTableAndSql.Keys)
                {
                    cmd.CommandText = dicTableAndSql[tbName];
                    da.Fill(ds, tbName);
                }
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("执行 public DataSet GetDataSet(Dictionary<string,string> dicTableAndSql)方法发生异常：" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
