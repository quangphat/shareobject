﻿using System;
using System.Collections.Generic;
using System.Text;


    public class ResponseJsonModel
    {
        public ErrorJsonModel error { get; set; }
        public bool success { get; set; }
    }
    public class ResponseJsonModel<T> : ResponseJsonModel 
    {
        public T data { get; set; }
    }
    public class ResponseActionJsonModel : ResponseJsonModel
    {
        public bool? success { get; set; }
    }

