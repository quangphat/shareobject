using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my8ViewObject
{
    public class FilterModel
    {
        public FilterType FilterType { get; set; }
        public List<FilterField> Fields { get; set; }
    }

    public class FilterField
    {
        public string Code { get; set; }
        public string Display { get; set; }
        public string ValueAcceptType { get; set; }
        public string OperatorText { get; set; }
        public bool HasOptions { get; set; }
        public bool IsNumberic { get; set; }
        public List<FilterFieldOption> Options { get; set; }
        public List<string> Values { get; set; }
    }
    public class FilterFieldOption
    {
        public string Code { get; set; }
        public string Display { get; set; }
        public string OperatorText { get; set; }
    }
    public enum FilterType
    {
        Article = 1,
        People = 2,
        Job = 3
    }
}
