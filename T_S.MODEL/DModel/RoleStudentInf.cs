using PSI.Common.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T_S.MODEL.DModel
{
    /// <summary>
    /// 角色菜单关系信息实体
    /// </summary>
    [Serializable]
    [Table("RoleStudentInfo")]
    [PrimaryKey("RMId")]
    public class RoleStudentInf
    {
        public int RS_ID { get; set; }
        public string RO_ID { get; set; }
        public string STU_ID { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
