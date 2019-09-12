using System;
using System.Collections.Generic;

namespace my8BackendObject.Mongos
{
    public class ResponseJsonModel
    {
        public ErrorJsonModel error { get; set; }
        public bool success { get; set; }
    }

    public class ResponseJsonModel<T> : ResponseJsonModel where T : class
    {
        public T data { get; set; }
    }
    public class ErrorJsonModel
    {
        public string code { get; set; }
        public string message { get; set; }
        public List<object> trace_keys { get; set; }
    }
}
