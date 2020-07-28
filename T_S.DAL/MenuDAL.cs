using System.Collections.Generic;
using T_S.MODEL.DModel;

namespace T_S.DAL
{
    public class MenuDAL:BaseDAL<Menu>
    {
        public List<Menu> GetMenuList()
        {
            string where = "order by Morder";
            string cols = "M_ID,Menu_Name,ParentId,MKey,MUrl,IsTop";
            return GetModelList(where, cols);
        }

        public List<Menu> GetMenuList(string roleids)
        {
            string where = "1=1";
            string cols = "M_ID,Menu_Name,ParentId,MKey,MUrl,IsTop,TMDesp";
            if (!string.IsNullOrEmpty(roleids))
            {
                where += $"and M_ID in (select M_ID FROM RoleMenuInfo where RO_ID IN ({roleids}) )";
            }

            where += "order by Morder";


            return GetModelList(where, cols);
        }
    }
}