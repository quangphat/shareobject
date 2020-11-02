using System;
using System.Collections.Generic;
using System.Text;

namespace my8ShareObject.Enums
{
    public static class AccountRole
    {
        public const string Client = "client";
        public const string Manager = "manager";
        public const string Editor = "editor";
        public const string Employee = "employee";
    }
    public static class ProjectType
    {
        public const string GreenCode = "greencode";
    }
    public enum ArticleStatusType
    {
        Draft = 0,
        Pending = 1,
        Approved = 2,
        Reject = 3
    }

    public enum JobStatusType
    {
        Draft = 0,
        WaitingForApproving = 1,
        Approved = 2,
        Reject = 3
    }
    public enum LocationType
    {
        Country = 1,
        City = 2,
        District = 3,
        Ward = 4
    }
    public enum ObjectType
    {
        Article = 1,
        Job = 2,
        People = 3,
        Company = 4
    }
    public enum TagType
    {
        JobFunction = 1,
        Industry = 2,
        GreenCode = 3
    }
    public enum TargetType
    {
        Feed = 1,
        Comment = 2,
        Reply = 3
    }
    public enum FilterType
    {
        Article = 1,
        People = 2,
        Job = 3
    }

    public enum AccountType
    {
        Employee =1,
        Employer =2
    }
}
