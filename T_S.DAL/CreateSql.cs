﻿using PSI.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace T_S.DAL
{
    public class CreateSql
    {
        /// <summary>
        /// 生成Insert语句
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="cols"></param>
        /// <returns></returns>
        public static SqlModel GetInsertSqlAndParas<T>(T t,string cols,int isReturn)
        {
            Type type = typeof(T);
            PropertyInfo[] properties = PropertyHelper.GetTypeProperties<T>(cols);
            string priName = type.GetPrimary();
            //生成要插入的列 {1}
            string columns = string.Join(",", properties.Where(p => p.Name != priName).Select(p => $"[{p.GetColName()}]"));
            //生成插入的参数{2}
            string paraColumns = string.Join(",", properties.Where(p => p.Name != priName).Select(p => $"@{p.GetColName()}"));
            //参数数组的生成
            SqlParameter[] arrParas = CreateParameters<T>(properties, t);
           
            //sql语句
            string sql = $"INSERT INTO [{type.GetTName()}] ({columns}) VALUES ({paraColumns}) ";
            if (isReturn == 1)
                sql += ";select @@identity";
            return new SqlModel() { Sql = sql, SqlParaArray = arrParas };

        }

        /// <summary>
        /// 生成Update语句
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="cols"></param>
        /// <returns></returns>
        public static SqlModel GetUpdateSqlAndParas<T>(T t,string cols,string strWhere)
        {
            Type type = typeof(T);
            //获取所有属性
            PropertyInfo[] properties = PropertyHelper.GetTypeProperties<T>(cols);
            string priName = type.GetPrimary();
            //生成要更新的列 {1}
            string columns = string.Join(",", properties.Where(p=>p.Name !=priName).Select(p => string.Format("[{0}]=@{0}",p.GetColName())));
;            //参数数组的生成
            SqlParameter[] arrParas = CreateParameters<T>(properties, t);

            if (string.IsNullOrEmpty(strWhere))
            {
                strWhere = $"{priName}=@{priName}";
            }
               

            //sql语句
            string sql = $"UPDATE [{type.GetTName()}] SET {columns} WHERE {strWhere}";
            return new SqlModel() { Sql = sql, SqlParaArray = arrParas };

        }

        /// <summary>
        /// 生成Delete语句
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public static string CreateDeleteSql<T>(string strWhere)
        {
            Type type = typeof(T);
            string sql = $"DELETE FROM [{type.GetTName()}] WHERE 1=1";
            if (!string.IsNullOrEmpty(strWhere))
                sql += strWhere;
            return sql;
        }


        /// <summary>
        ///生成查询语句
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="strWhere"></param>
        /// <param name="listCols"></param>
        /// <returns></returns>
        public static string CreateSelectSql<T>(string strWhere, string cols)
        {
            Type type = typeof(T);
            PropertyInfo[] properties = PropertyHelper.GetTypeProperties<T>(cols);

            //string columns = string.Join(",", properties.Select(p => $"[{p.GetColName()}]"));

            if (string.IsNullOrEmpty(strWhere)) strWhere = "1=1";
            string sql = $"SELECT {cols} FROM [{type.GetTName()}] WHERE {strWhere}";
            return sql;
        }

        /// <summary>
        /// 获取带自编号的select语句，主要用于分页查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="strWhere"></param>
        /// <param name="cols"></param>
        /// <returns></returns>
        public static string CreateRowsSelectSql<T>(string strWhere, string cols)
        {
            Type type = typeof(T);
            PropertyInfo[] properties = PropertyHelper.GetTypeProperties<T>(cols);

            string columns = string.Join(",", properties.Select(p => $"[{p.GetColName()}]"));
            string priName = type.GetPrimary();
            if (string.IsNullOrEmpty(strWhere)) strWhere = "1=1";
            string sql = $"SELECT ROW_NUMBER() OVER ( ORDER BY {priName} ASC ) AS Id,{ columns} FROM [{type.GetTName()}] WHERE {strWhere}";
            return sql;
        }

        //生成参数数组
        
        private static SqlParameter[] CreateParameters<T>(PropertyInfo[] properties, T t)
        {
            SqlParameter[] arrParas = properties.Select(p => new SqlParameter("@" + p.GetColName(), p.GetValue(t) ?? DBNull.Value)).ToArray();
            return arrParas;
        }


    }
}
