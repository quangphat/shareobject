using System;
using System.Collections.Generic;
using System.Text;

namespace my8ShareObject
{
    public class RefreshTokenRequest
    {
        public string Email { get; set; }
        public string OldToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
