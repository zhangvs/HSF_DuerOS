﻿using CloudApi.Dueros.Models.CommonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudApi.Dueros.Models.ReceiveModel
{
    public class SetBrightnessPercentagePayload:CommonRecievePayload
    {
        public ValueModel brightness { get; set; }
         
    }
}