using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my8ViewObject
{
    public class FilterModelBase
    {
        public int page { get; set; }
        public int limit { get; set; }
        public string freeText { get; set; }
    }
}
