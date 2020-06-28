using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace T_S.DBUtility
{
    public class SqlHelper
    {
        /// <summary>
        /// 链接字符串
        /// </summary>
        private static string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
           

      /*
  
        public static DataTable GetDataTable(string sql, CommandType type, params SqlParameter[] paras)
        {
            using (SqlConnection conn = new SqlConnection(connStr))//创建连接对象
            {
                //创建适配器对象
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                {
                    if (paras != null)
                    {
                        adapter.SelectCommand.Parameters.AddRange(paras);//添加参数
                    }
                    adapter.SelectCommand.CommandType = type;
                    DataTable dt = new DataTable();//构造数据表用于接收查询结果                   
                    adapter.Fill(dt);//执行结果，fill方法内部自动打开链接，不需要conn.open();   
                    adapter.SelectCommand.Parameters.Clear();//清空集合
                    return dt; //返回结果集       
                }
            }
        }
        //1.ExecuteNonQuery(); : //执行命令的方法：insert update delete
        //它的返回值类型为int型。多用于执行增加，删除，修改数据，返回受影响的行数。当select操作时，返回-1。
        //ExecuteNonQuery()方法主要用户更新数据，通常它使用Update,Insert,Delete语句来操作数据库，
        //其方法返回值意义：对于 Update, Insert, Delete 语句 执行成功是返回值为该命令所影响的行数，如果影响的行数为0时返回的值为0，
        //params是关键字:是可变参数的意思，目的是省略手动构造数组的过程，直接指定对象编译器会帮助我们构造数组，并将对象加入数组中传递过来
        public static int ExcuteNonQuery(string sql, CommandType type, params SqlParameter[] paras)
        {
            using (SqlConnection conn = new SqlConnection(connStr))//创建连接对象
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn)) //创建Command连接对象
                {
                    if (paras != null)
                    {
                        cmd.Parameters.AddRange(paras);//添加参数
                    }
                    cmd.CommandType = type;
                    conn.Open();//打开链接 
                    int n = cmd.ExecuteNonQuery(); //执行命令并返回受影响的行数  
                    cmd.Parameters.Clear();
                    return n;
                }

            }
        }

        //ExecuteScaler(); 获取首行首列的方法
        //它的返回值类型多位int类型。它返回的多为执行select查询。得到的返回结果为一个值的情况，比如使用count函数求表中记录个数或者使用sum函数求和等。
        //ExecuteScalar()方法也用来执行SQL语句，但是ExecuteScalar()执行SQL语句后的返回值与ExecuteNonQuery()并不相同，
        //ExecuteScalar()方法的返回值的数据类型是Object类型。
        //如果执行的SQL语句是一个查询语句（SELECT），则返回结果是查询后的第一行的第一列，
        //如果执行的SQL语句不是一个查询语句，则会返回一个未实例化的对象，必须通过类型转换来显示，
       

        public static object ExecuteScalar(string sql, CommandType type, params SqlParameter[] paras)
        {
            using (SqlConnection conn = new SqlConnection(connStr))//创建连接对象
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn)) //创建Command连接对象
                {
                    if (paras != null)
                    {
                        cmd.Parameters.AddRange(paras);//添加参数
                    }
                    cmd.CommandType = type;
                    conn.Open();//打开链接                    
                    return cmd.ExecuteScalar(); ;
                }

            }
        }*/
        //适合增删改操作，返回影响条数
        public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand comm = conn.CreateCommand())
                {
                    try
                    {
                        conn.Open();
                        comm.CommandText = sql;
                        if (parameters != null)
                            comm.Parameters.AddRange(parameters);
                        return comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    finally
                    {
                        if (conn != null && conn.State != ConnectionState.Closed)
                            conn.Close();
                    }

                }
            }
        }

        //查询操作，返回查询结果中的第一行第一列的值
        public static object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand comm = conn.CreateCommand())
                {
                    try
                    {
                        conn.Open();
                        comm.CommandText = sql;
                        if (parameters != null)
                            comm.Parameters.AddRange(parameters);
                        return comm.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    finally
                    {
                        if (conn != null && conn.State != ConnectionState.Closed)
                            conn.Close();
                    }
                }
            }
        }

        //Adapter调整，查询操作，返回DataTable
        public static DataTable ExecuteDataTable(string sql, params SqlParameter[] parameters)
        {

            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connStr))
            {
                DataTable dt = new DataTable();
                if (parameters != null)
                    adapter.SelectCommand.Parameters.AddRange(parameters);
                adapter.Fill(dt);
                return dt;
            }
        }

        //dataset
        public static DataSet ExecuteDataset(string sql, params SqlParameter[] parameters)
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connStr))
            {
                DataSet ds = new DataSet();
                if (parameters != null)
                    adapter.SelectCommand.Parameters.AddRange(parameters);
                adapter.Fill(ds);
                return ds;
                ////表集合
                //DataTableCollection table = ds.Tables;
            }
        }

        //datareader
        public static SqlDataReader ExecuteReader(string sqlText, params SqlParameter[] parameters)
        {
            //SqlDataReader要求，它读取数据的时候有，它独占它的SqlConnection对象，而且SqlConnection必须是Open状态
            SqlConnection conn = new SqlConnection(connStr);//不要释放连接，因为后面还需要连接打开状态
            SqlCommand cmd = conn.CreateCommand();
            conn.Open();
            cmd.CommandText = sqlText;
            if (parameters != null)
                cmd.Parameters.AddRange(parameters);
            //CommandBehavior.CloseConnection当SqlDataReader释放的时候，顺便把SqlConnection对象也释放掉
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }


        /// <summary> 
        /// 执行多条SQL语句，实现数据库事务。 
        /// </summary> 
        /// <param name="SQLStringList">多条SQL语句</param>      
        public static int ExecuteSqlTran(List<String> SQLStringList)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                SqlTransaction tx = conn.BeginTransaction();
                cmd.Transaction = tx;
                try
                {
                    int count = 0;
                    for (int n = 0; n < SQLStringList.Count; n++)
                    {
                        string strsql = SQLStringList[n];
                        if (strsql.Trim().Length > 1)
                        {
                            cmd.CommandText = strsql;
                            count += cmd.ExecuteNonQuery();
                        }
                    }
                    tx.Commit();
                    return count;
                }
                catch
                {
                    tx.Rollback();
                    return 0;
                }
            }
        }

        /// <summary> 
        /// 执行存储过程，返回SqlDataReader ( 注意：调用该方法后，一定要对SqlDataReader进行Close ) 
        /// </summary> 
        /// <param name="storedProcName">存储过程名</param> 
        /// <param name="parameters">存储过程参数</param> 
        /// <returns>SqlDataReader</returns> 
        public static SqlDataReader RunProcedure(string storedProcName, IDataParameter[] parameters)
        {
            SqlConnection connection = new SqlConnection(connStr);
            SqlDataReader returnReader;
            connection.Open();
            SqlCommand command = BuildQueryCommand(connection, storedProcName, parameters);
            command.CommandType = CommandType.StoredProcedure;
            returnReader = command.ExecuteReader(CommandBehavior.CloseConnection);
            return returnReader;

        }
        private static SqlCommand BuildQueryCommand(SqlConnection connection, string storedProcName, IDataParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(storedProcName, connection);
            command.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter parameter in parameters)
            {
                if (parameter != null)
                {
                    // 检查未分配值的输出参数,将其分配以DBNull.Value. 
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                        (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    command.Parameters.Add(parameter);
                }
            }

            return command;
        }



    }
}