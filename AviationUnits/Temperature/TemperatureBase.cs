﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public class TemperatureBase : Unit<ITemperature>, ITemperature
    {
        public override Type BaseUnit
        {
            get { throw new NotImplementedException(); }
        }
    }
}