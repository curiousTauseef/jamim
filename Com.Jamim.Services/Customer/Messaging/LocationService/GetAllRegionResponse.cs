﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Com.Jamim.Services.Customer.ViewModels;

namespace Com.Jamim.Services.Customer.Messaging.LocationService
{
    public class GetAllRegionResponse
    {
        public IEnumerable<RegionView> RegionViews { get; set; }
    }
}
