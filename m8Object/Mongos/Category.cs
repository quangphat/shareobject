using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace my8BackendObject.Mongos
{
    public class Category
    {
        public Category() { }
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string CategoryName { get; set; }
        public string[] CategoryIds { get; set; }
        public string[] CategoryNames { get; set; }
        public bool IsRoot { get; set; }
        public string ParentCategoryId { get; set; }
        public int Level { get; set; }
        public List<Category> SubCategories { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public string ProjectId { get; set; }
    }
}

