using PSI.Common.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T_S.MODEL.DModel
{
    /// <summary>
    /// 角色信息实体
    /// </summary>
    [Serializable]
    [Table("Role")]
    [PrimaryKey("R_ID")]
    public class Role
    {
        public int R_ID { get; set; }
        public string RoleName { get; set; }
        public string Remark { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
