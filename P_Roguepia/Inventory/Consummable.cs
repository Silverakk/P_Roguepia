using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_RogueTower
{
    [Serializable]
    abstract class Consummable : Item
    {
        private int _numberOFUsage;
        private bool _hasTimeCounter;
        private int _timeCounter;
        public int NumberOFUsage { get => _numberOFUsage; set => _numberOFUsage = value; }
        public bool HasTimeCounter { get => _hasTimeCounter; set => _hasTimeCounter = value; }
        public int TimeCounter { get => _timeCounter; set => _timeCounter = value; }

        public Consummable(string name, int price, string description = null, int numberOfUsage = 1, bool hasTimeCounter = false, int timeCounter = 3) :base(name,price, description)
        {
            NumberOFUsage = numberOfUsage;
            HasTimeCounter = hasTimeCounter;
            TimeCounter = timeCounter;

        }

        

        public virtual void Consume(Game game)
        {

        }
        public virtual void EndOfTimeCounter(Game game)
        {

        }
    }
}
