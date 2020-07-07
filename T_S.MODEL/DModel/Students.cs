using PSI.Common.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T_S.MODEL.DModel
{
    [Table("Students")]
    [PrimaryKey("Stu_ID")]
    public class Students
    {
        public string Stu_ID  { get; set; }
        public string Name { get; set; }
        public string Student_Number { get; set; }
        public string Psw { get; set; }
        public int Age { get; set; }
        public string gender { get; set; }
        public DateTime birthday { get; set; }
        public string address { get; set; }
        public DateTime CreateTime { get; set; }


    }
}
