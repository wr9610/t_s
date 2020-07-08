using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_S.MODEL.DModel;

namespace T_S.DAL
{
    public class LoginDAL:BaseDAL<Students>
    {
        public int Log(string n, string p) 
        {
            string where = "Student_Number=@Name and Psw=@Psw";
            SqlParameter[] parameters =
            { 
                new SqlParameter("@Name",n),
                 new SqlParameter("@Psw",p)

            };
            Students students = GetModel(where, "Stu_id", parameters);
            if (students != null)
                return students.Stu_ID;
            else
                return 0;
           
        }
    }
}
