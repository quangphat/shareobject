﻿using System;
using System.Collections.Generic;
using System.Text;

namespace my8ShareObject.Infrastructures
{
    public class MongoConnection
    {
        public string ServerURl { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Database { get; set; }
    }
}
