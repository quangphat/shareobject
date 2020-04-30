using System;
using System.Collections.Generic;
using System.Text;

namespace CoreObject
{
    public class AccountSearch
    {
        public AccountSearch()
        {

        }
        public AccountSearch(string searchStr, int page, int limit, string role)
        {
            this.page = page < 0 ? 1 : page;
            this.limit = limit <= 0 ? 20 : limit;
            this.searchStr = searchStr == null ? string.Empty : searchStr.ToLower();
            this.role = role == null ? string.Empty : role.ToLower();
        }
        public string searchStr { get; set; }
        public string role { get; set; }
        public int page { get; set; } = 1;
        public int limit { get; set; } = 20;
    }
}
