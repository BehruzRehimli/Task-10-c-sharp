﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dersde_10_Task
{
    internal class Bicycle : Vehicle
    {
        public override void Drive(int km)
        {
            Mileage += km;
        }
    }
}
