﻿using my8ShareObject.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace my8ShareObject.Request
{
    public class CompanyRegisterModel : RegisterModel
    {
        public string Phone { get; set; }
        public List<JobSkillSimple> Skills { get; set; }
        public List<IndustrySimple> Industries { get; set; }
        public LocationSimple Headquarter { get; set; }
    }
}
