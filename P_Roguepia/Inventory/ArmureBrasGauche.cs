using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_RogueTower.LivingCreatures
{
    [Serializable]
    abstract class ArmureBrasGauche : Equipement
    {
        public ArmureBrasGauche(string name, int price, string description = null) : base(name, price, description)
        {

        }
        public virtual string Block(Game game)
        {
            return null;
        }

    }
}
