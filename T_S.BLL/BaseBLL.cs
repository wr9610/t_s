using PSI.Common;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_S.DAL;
using T_S.MODEL.VModel;

namespace T_S.BLL
{
    public class BaseBLL<T> where T : class
    {
        private BaseDAL<T> dal = new BaseDAL<T>();

        #region 添加
        /// <summary>
        /// 添加实体信息
        /// </summary>
        /// <param name="t"></param>
        /// <param name="strCols">插入列名字符串，若为空，则全插入</param>
        /// <returns></returns>
        public bool Add(T t, string strCols)
        {
            return dal.Add(t, strCols,0)>0;
        }

        /// <summary>
        /// 添加实体信息，返回新增的Id
        /// </summary>
        /// <param name="t"></param>
        /// <param name="strCols"></param>
        /// <returns></returns>
        public int AddReturnId(T t,string strCols)
        {
            return dal.Add(t, strCols, 1);
        }

        /// <summary>
        /// 批量插入
        /// </summary>
        /// <param name="list"></param>
        /// <param name="strCols"></param>
        /// <returns></returns>
        public bool AddList(List<T> list, string strCols)
        {
            return dal.AddList(list, strCols);
        }
        #endregion

        #region 修改
        /// <summary>
        /// 修改信息实体
        /// </summary>
        /// <param name="t"></param>
        /// <param name="strCols">要修改的列，包括主键列名</param>
      
        /// <returns></returns>
        public bool Update(T t, string strCols)
        {
            return dal.Update(t, strCols);
        }

        /// <summary>
        /// 批量修改
        /// </summary>
        /// <param name="list"></param>
        /// <param name="strCols"></param>
        /// <returns></returns>
        public bool UpdateList(List<T> list, string strCols)
        {
            return dal.UpdateList(list, strCols);

        }
        #endregion

        #region 删除
        /// <summary>
        /// 根据Id删除  这里id是主键 delType=1 真删除  0 假删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id, int delType)
        {
            return dal.Delete(id, delType);
        }


        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="idList"></param>
        /// <returns></returns>
        public bool DeleteList(List<int> idList, int actType)
        {
            return dal.DeleteList(idList, actType);
        }
        #endregion

        #region 查询

        /// <summary>
        /// 根据Id获取信息实体
        /// </summary>
        /// <param name="id"></param>
        /// <param name="strCols"></param>
        /// <returns></returns>
        public T GetById(int id, string strCols)
        {
            return dal.GetById(id, strCols);
        }
        /// <summary>
        /// 根据 名称 判断是否已存在
        /// </summary>
        /// <param name="sName"></param>
        /// <param name="sId"></param>
        /// <param name="vName"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool ExistsByName(string sName, string vName)
        {
            return dal.ExistsByName(sName, vName);
        }

        /// <summary>
        /// 同一级别下,检查是否同名
        /// </summary>
        /// <param name="sName"></param>
        /// <param name="sId"></param>
        /// <param name="vName"></param>
        /// <param name="id"></param>
        /// <param name="sParent"></param>
        /// <param name="parId"></param>
        /// <returns></returns>
        public bool ExistsByName(string sName,  string vName, string sParent, int parId)
        {
            return dal.ExistsByName(sName,  vName, sParent, parId);
        }
        /// <summary>
        /// 获取所有列表
        /// </summary>
        /// <param name="strCols"></param>
        /// <returns></returns>
        public List<T> GetModelList(string strCols)
        {
            return dal.GetModelList(strCols);
        }

        
        /// <summary>
        /// 将DataSet 转换为PageModel<S> 针对分页查询得到的DataSet
        /// </summary>
        /// <typeparam name="S"></typeparam>
        /// <param name="ds"></param>
        /// <param name="cols"></param>
        /// <returns></returns>
        public PageModel<S> DsToPageModel<S>(DataSet ds,string cols)
        {
            int total = (int)ds.Tables[0].Rows[0][0];
            List<S> list = DbConvert.DataTableToList<S>(ds.Tables[1], cols);
            return new PageModel<S>() { TotalCount = total, ReList = list };
        }
        #endregion
    }
}