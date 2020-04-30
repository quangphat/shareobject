using System;
using System.Collections.Generic;
using System.Text;

namespace CoreObject
{
    public class Pagination<T> where T : class
    {
        public List<T> Datas { get; set; }
        public int TotalRecord { get; set; }
    }
}
