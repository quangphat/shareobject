using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace my8ShareObject.SimpleModel
{
    [BsonIgnoreExtraElements]
    public class CountrySimple
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string CountryName { get; set; }
        public string FlagUrl { get; set; }
    }
}
