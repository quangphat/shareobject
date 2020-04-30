using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreObject.Mongo
{
    [BsonIgnoreExtraElements]
    public class MGPagination<TEntity>
    {
        public int total { get; set; }
        public IEnumerable<TEntity> datas { get; set; }
    }
}
