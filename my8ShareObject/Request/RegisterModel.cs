using System;
using System.Collections.Generic;
using System.Text;

namespace my8ShareObject.Request
{
    public class RegisterModel
    {
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public bool IsAcceptPolicy { get; set; }
    }
}
