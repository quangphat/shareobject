﻿
namespace my8ShareObject.ViewModels
{
    public class LoginModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool RememberLogin { get; set; }
        public string ReturnUrl { get; set; }
    }
}
