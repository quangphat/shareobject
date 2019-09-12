﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my8ViewObject
{
    public class LocationView
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string CountryCode { get; set; }
        public string ProvinceCode { get; set; }
        public string DistrictCode { get; set; }
        public string DisplayName { get; set; }
        public int LocationType { get; set; }
        public int OrderPoint { get; set; }
    }
}
