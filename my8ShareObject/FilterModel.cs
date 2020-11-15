using my8ShareObject.Enums;
using my8ShareObject.Mongo;
using System;
using System.Collections.Generic;


public class FilterModel : MongoBaseModel
{
    public string FilterType { get; set; }
    public List<FilterField> Fields { get; set; }
}

public class FilterField
{
    public string FieldName { get; set; }
    public string Display { get; set; }
    public string ValueType { get; set; }
    public string Operator { get; set; }
    public bool HasOption { get; set; }
    public bool IsNumeric { get; set; }
    public List<FilterFieldOption> Options { get; set; }
}
public class FilterFieldOption
{
    public string Code { get; set; }
    public string Display { get; set; }
}


