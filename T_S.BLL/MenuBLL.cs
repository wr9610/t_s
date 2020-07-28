using System.Collections.Generic;
using T_S.DAL;
using T_S.MODEL.DModel;

namespace T_S.BLL
{
    public class MenuBLL:BaseBLL<Menu>
    {
        MenuDAL menuDal=new MenuDAL();
       
        public List<Menu> GetMenuList(string RoleId)
        {
            return  menuDal.GetMenuList(RoleId);
        }
    }
}