﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_S.DAL
{
    public class SqlModel
    {
        //sql语句
        public string Sql { get; set; }
        //参数数组
        public SqlParameter[] SqlParaArray { get; set; }

    }
}
