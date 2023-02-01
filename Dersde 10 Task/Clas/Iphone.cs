using System;
using System.Collections.Generic;
using System.Text;

namespace Clas
{
    internal class Iphone : Phone,IChargeable
    {
        public Iphone(int battarycapacity, int battarycharge1min, int currentbattarycapacty = 0) : base(battarycapacity, battarycharge1min, currentbattarycapacty)
        {
        }

        public void Charge(int minute)
        {
            if (_currentBattaryCapacity + minute * _battaryCharge1Min <= _battaryCapacity)
            {
                _currentBattaryCapacity += minute * _battaryCharge1Min;
            }
        }
    }
}
