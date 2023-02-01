using System;
using System.Collections.Generic;
using System.Text;

namespace Dersde_10_Task
{
    internal class Car : Vehicle
    {
        public int CurrentFuel;
        public int FuelFor1Km;
        public override void Drive(int km)
        {
            CurrentFuel-=km*FuelFor1Km;
            Mileage += km;
        }
    }
}
