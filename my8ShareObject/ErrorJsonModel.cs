
using System.Collections.Generic;

    public class ErrorJsonModel
    {
        public string code { get; set; }
        public string message { get; set; }
        public List<object> trace_keys { get; set; }
    }

