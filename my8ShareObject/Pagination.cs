
using System.Collections.Generic;


    public class Pagination<T> where T : class
    {
        public List<T> Datas { get; set; }
        public int TotalRecord { get; set; }
    }

