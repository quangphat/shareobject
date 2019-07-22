using System;
using System.Collections.Generic;
using System.Text;

namespace my8.ShareObject.ESB
{
    public class SearchModelMsg
    {
        public string Id { get; set; }
        public string FeedId { get; set; }
        public ObjectType ObjectType { get; set; } 
        public string Title { get; set; }
        public string[] Tags { get; set; } 
        public string ProjectId { get; set; }
    }
}
