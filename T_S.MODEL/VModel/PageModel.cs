using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_S.MODEL.VModel
{
    public class PageModel<T>
    {
        public int TotalCount { get; set; }
        public List<T> ReList { get; set; }

    }
}
