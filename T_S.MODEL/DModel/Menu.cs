using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using PSI.Common.CustomAttributes;

namespace T_S.MODEL.DModel
{
    /// <summary>
    /// 角色信息实体
    /// </summary>
    [Serializable]
    [Table("Menu")]
    [PrimaryKey("M_ID")]
    public class Menu
    {

        /// <summary>
        /// MId
        /// </summary>		
        public int M_ID { get; set; }
        /// <summary>
        /// MName
        /// </summary>		
        public string Menu_Name { get; set; }
        /// <summary>
        /// ParentId
        /// </summary>		
        public int? ParentId { get; set; }
        /// <summary>
        /// ParentName
        /// </summary>		
        public string ParentName { get; set; }
        /// <summary>
        /// MKey
        /// </summary>		
        public string MKey { get; set; }
        /// <summary>
        /// MUrl
        /// </summary>		
        public string MUrl { get; set; }
        /// <summary>
        /// IsTop
        /// </summary>		
        public int IsTop { get; set; }
        /// <summary>
        /// MOrder
        /// </summary>		
        public int MOrder { get; set; }
        /// <summary>
        /// IsDeleted
        /// </summary>		
        public int IsDeleted { get; set; }
        /// <summary>
        /// Creator
        /// </summary>		
        public string Creator { get; set; }
        /// <summary>
        /// CreateTime
        /// </summary>		
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// TMDesp
        /// </summary>
        public string TMDesp { get; set; }
    }
}

