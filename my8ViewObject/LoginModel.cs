﻿using System;
using System.Collections.Generic;
using System.Text;

namespace my8ViewObject
{
    public class LoginModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool RememberLogin { get; set; }
        public string ReturnUrl { get; set; }
    }
}
