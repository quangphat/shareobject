using System;
using System.Collections.Generic;
using System.Text;

namespace my8ViewObject
{
    public class ErrorJsonModel
    {
        public string code { get; set; }
        public string message { get; set; }
        public List<object> trace_keys { get; set; }
    }
}
