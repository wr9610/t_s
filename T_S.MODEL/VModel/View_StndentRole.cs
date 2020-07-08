using PSI.Common.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace T_S.MODEL.VModel
{

    [Table("View_StndentRole")]
   public class View_StndentRole
    {
        public string Name { get; set; }
        public string RoleName { get; set; }
        public int R_ID { get; set; }
        public int STU_ID { get; set; }
    }
}
