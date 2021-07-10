using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace my8ShareObject.Enums
{

    public static class ESEmploymentType
    {
        public const string PartTime = "parttime";
        public const string FullTime = "fulltime";
        public const string Contract = "contract";
        public const string Internship = "internship";
        public const string Temperory = "temperory";
        public const string Volunteer = "volunteer";
    }

    public enum SoftWareType
    {
        Product = 1,
        OutSource =2,
        ProductAndOutSource = 3
    }

    public enum EExperienceLevel
    {
        [Description("Fresher")]
        Fresher =0,
        [Description("1 year")]
        OneYear =1,
        [Description("2 years")]
        TwoYear = 2,
        [Description("3 years")]
        ThreeYear =3,
        [Description("4 years")]
        FourYear = 4,
        [Description("5 years")]
        FiveYear = 5,
        [Description("6 years")]
        SixYear = 6,
        [Description("7 years")]
        SevenYear = 7,
        [Description("8 years")]
        EightYear = 8,
        [Description("9 years")]
        NineYear = 9,
        [Description("10 years")]
        TenYear = 10,
        [Description("Over 10 years")]
        OverTenYear = 11,
        

    }

    public static class AccountRole
    {
        public const string Client = "client";
        public const string Manager = "manager";
        public const string Editor = "editor";
        public const string Employee = "employee";
    }

    public static class AccountSource
    {
        public const string jobbridge = "jobbridge";
        public const string google = "google";
        public const string github = "github";
        public const string linkedin = "linkedin";
    }


    public static class FilterType
    {
        public const string Job = "job";
        public const string Article = "article";
    }

    public static class EmailTemplateType
    {
        public const string register = "register";
        public const string forgot_password = "forgot_password";
    }

    public enum ActivateAccountType
    {
        Active =1,
        ForgotPassword = 2
    }

    public static class ProjectType
    {
        public const string GreenCode = "greencode";
    }

    public enum ApplyJobStatus
    {
        Pending = 1,
        Approved = 2,
        Reject = 3
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
    //public enum FilterType
    //{
    //    Article = 1,
    //    People = 2,
    //    Job = 3
    //}

    public enum AccountType
    {
        Employee = 1,
        Employer = 2
    }

    public enum SortBy
    {
        Ascending = 1,
        Descending = 2
    }
}
