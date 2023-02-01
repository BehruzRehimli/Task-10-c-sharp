using System;
using System.Collections.Generic;
using System.Text;

namespace Clas
{
    public abstract class Phone
    {
        public Phone(int battarycapacity,int battarycharge1min, int currentbattarycapacty=0  )
        {
            _battaryCapacity= battarycapacity;
            _battaryCharge1Min=battarycharge1min;
            _currentBattaryCapacity= currentbattarycapacty;
        }
        protected int _battaryCapacity;
        public int BattaryCapacity { get { return _battaryCapacity; } }
        protected int _battaryCharge1Min;
        public int BattaryCharge1Min
        {
            get { return _battaryCharge1Min; }
        }
        protected int _currentBattaryCapacity;
        public int CurrentBattaryCapacity { get { return _currentBattaryCapacity; } }
    }
}
