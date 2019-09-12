using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my8BackendObject
{
    public class ArticleSearch
    {
        public ArticleSearch()
        {

        }
        public ArticleSearch(string searchStr, int page, int limit, string authorId)
        {
            this.Page = page < 0 ? 1 : page;
            this.Limit = limit <= 0 ? 20 : limit;
            this.SearchStr = searchStr == null ? string.Empty : searchStr;
            this.AuthorId = authorId == null ? string.Empty : authorId.ToLower();
           // this.CategoryId = categoryId == null ? string.Empty : categoryId.ToLower();
        }
        public string SearchStr { get; set; }
        //public string CategoryId { get; set; }
        public string AuthorId { get; set; }
        public int Page { get; set; } = 1;
        public int Limit { get; set; } = 20;
    }
    public enum SortType
    {
        CreatedTime = 1,
        ModifiedTime = 2,
        Likes = 3,
        Comments = 4,
        Shares = 5
    }
}
