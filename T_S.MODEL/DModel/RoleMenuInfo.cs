using System;
using PSI.Common.CustomAttributes;

namespace T_S.MODEL.DModel
{
    /// <summary>
    /// 角色信息实体
    /// </summary>
    [Serializable]
    [Table("RoleMenuInfo")]
    [PrimaryKey("RM_ID")]
    public class RoleMenuInfo
    {
        public int RM_ID { get; set; }
        public int RO_ID { get; set; }
        public int ME_ID { get; set; }
        public DateTime CreateTime { get; set; }
    }
}