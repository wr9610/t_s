using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_S.MODEL.VModel;

namespace T_S.DAL
{
   public class ViewStudentRoleDAL:BQuery<View_StndentRole>
    {
        public List<View_StndentRole> GetStudentRole(int Stu_id)
        {

            string where = "Stu_id=@Stu_id";
            SqlParameter parameter=new SqlParameter("@Stu_id", Stu_id);
            return GetModelList(where, "R_ID,RoleName,Stu_ID,Name", parameter);
        }
    }
}
