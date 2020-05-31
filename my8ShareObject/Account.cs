using System;
using System.Collections.Generic;
using System.Text;

namespace my8ShareObject
{
    public class Account
    {
        public Account() { }
        public string PersonId { get; set; }
        public string DisplayName { get; set; }
        public string ProfileName { get; set; }
        public string Avatar { get; set; }
        public string Headline { get; set; }
        public string Company { get; set; }
        public double Rate { get; set; }//Đánh giá 
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public string[] Scopes { get; set; }
        public string ProjectId { get; set; }
        public string[] SkillTags { get; set; }
        public string[] FollowingTags { get; set; }
        public bool IsBanned { get; set; }
    }
}
