using System;
namespace my8ShareObject.ViewModels
{
    public class ArticleFilterModel : FilterModelBase
    {
        public int status { get; set; }
        public string[] tags { get; set; }
        public string profileName { get; set; }
        public string authorId { get; set; }
        public string ignoreAuthorId { get; set; }
        public string[] ignoreArticleIds { get; set; }
        public DateTime? createdDate { get; set; }
        public DateTime? approvedDate { get; set; }
    }

}