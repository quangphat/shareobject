using System;
using System.Collections.Generic;
using System.Text;

namespace my8ViewObject
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
    public class ResponseActionJsonModel : ResponseJsonModel
    {
        public bool? success { get; set; }
    }
}
