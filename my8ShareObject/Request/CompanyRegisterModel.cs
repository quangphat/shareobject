using my8ShareObject.SimpleModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace my8ShareObject.Request
{
    public class CompanyRegisterModel : RegisterModel
    {
        public string Phone { get; set; }
        public List<JobSkillSimple> Skills { get; set; }
        public IndustrySimple Industry { get; set; }
        public LocationSimple Headquarter { get; set; }
    }
}
