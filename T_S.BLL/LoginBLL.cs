using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using T_S.DAL;
using T_S.MODEL.DModel;
using T_S.MODEL.VModel;

namespace T_S.BLL
{
    public class LoginBLL : BaseBLL<Students>
    {
        /// <summary>
        /// 登录逻辑
        /// </summary>
        LoginDAL login=new LoginDAL();
        ViewStudentRoleDAL viewStudentRole=new ViewStudentRoleDAL();

        public List<View_StndentRole> Login(string n, string p) 
        {
            List<View_StndentRole> roleStudentInfs = new List<View_StndentRole>();
            int Stu_id = login.Log(n, p);
            if (Stu_id>0)
            {
                roleStudentInfs = viewStudentRole.GetStudentRole(Stu_id);
            }
            return roleStudentInfs;
        }
  }
}
