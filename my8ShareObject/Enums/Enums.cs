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

    public enum EOTPolicy
    {
        NoOT = 1,
        HasOTPolicy = 2
    }

    public enum ECompanySize
    {
        OneTo50 =1,
        FiftyTo100 = 2,
        OneHundredTo200 =3,
        OneHundredTo300 = 4,
        OneHundredTo500 = 5,
        FiveHundredTo1000 =6,
        Over1000 = 7
    }

    public enum ESoftWareType
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

    public static class EAccountRole
    {
        public const string Client = "client";
        public const string Manager = "manager";
        public const string Editor = "editor";
        public const string Employee = "employee";
    }

    public static class EAccountSource
    {
        public const string jobbridge = "jobbridge";
        public const string google = "google";
        public const string github = "github";
        public const string linkedin = "linkedin";
    }


    public static class EFilterType
    {
        public const string Job = "job";
        public const string Article = "article";
    }

    public static class EEmailTemplateType
    {
        public const string register = "register";
        public const string forgot_password = "forgot_password";
    }

    public enum EActivateAccountType
    {
        Active =1,
        ForgotPassword = 2
    }

    public static class EProjectType
    {
        public const string GreenCode = "greencode";
    }

    public enum EApplyJobStatus
    {
        Pending = 1,
        Approved = 2,
        Reject = 3
    }
    public enum EArticleStatusType
    {
        Draft = 0,
        Pending = 1,
        Approved = 2,
        Reject = 3
    }

    public enum EJobStatusType
    {
        Draft = 0,
        WaitingForApproving = 1,
        Approved = 2,
        Reject = 3
    }
    public enum ELocationType
    {
        Country = 1,
        City = 2,
        District = 3,
        Ward = 4
    }
    public enum EObjectType
    {
        Article = 1,
        Job = 2,
        People = 3,
        Company = 4
    }
    public enum ETagType
    {
        JobFunction = 1,
        Industry = 2,
        GreenCode = 3
    }
    public enum ETargetType
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

    public enum EPackage
    {
        Free = 1
    }

    public enum ECvType
    {
        UseUploadedCv =1,
        UploadNew =2
    }
    public enum EAccountType
    {
        Employee = 1,
        Employer = 2
    }

    public enum ESortDirection
    {
        Ascending = 1,
        Descending = 2
    }

    public enum EReviewStatus
    {
        [Description("New")]
        New = 1,
        [Description("Approved")]
        Approved = 2,
        [Description("Reject")]
        Reject =3
    }

    public enum EMediaOwnerType
    {
        Employee = 1,
        Employer = 2,
        Company = 3,
        Job = 4
    }

    public enum EMediaType
    {
        Avatar =1,
        Cv = 2,
        CompanyPicture=3,
        JobCoverImage = 4
    }

    public enum EImageSize
    {
        [Description("w150xh170")]
        Small = 1,
        [Description("w500x700")]
        Medium = 2,
        [Description("w1280x720")]
        Large = 3,
        [Description("w800x500")]
        Thumbnail = 4,
        [Description("none")]
        None = 5,
        [Description("Avatar")]
        Avatar = 6,
    }
}
