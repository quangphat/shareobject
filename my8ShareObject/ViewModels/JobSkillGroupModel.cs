using MongoDB.Bson.Serialization.Attributes;
using my8ShareObject.SimpleModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace my8ShareObject.ViewModels
{
    [BsonIgnoreExtraElements]
    public class JobSkillGroupModel
    {
        public string Label { get; set; }
        public List<SelectItem> Options { get; set; }
    }
}
