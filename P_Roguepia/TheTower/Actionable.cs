using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_RogueTower
{
    [Serializable]
    abstract class Actionable : Lieu
    {
        public Actionable(
            int currentRoomId, int nextRoomId, int secondNextRoomId, 
            string name, string description = null,
            List<Monstre> monsterPool = null,
            bool light = true, bool isActionable = false, 
            bool isSkippable = true, 
            bool isStairs = false) 

            : base(currentRoomId, nextRoomId, secondNextRoomId,
                  name, description, monsterPool, 
                  light, isActionable, isSkippable, isStairs)
        {
            
        }
        public virtual void BecomeActionableWhenAllCreaturesAreDead(Game game)
        {
            
        }
        public virtual string ActionAndDescription(Game game)
        {
            return string.Empty;
        }
    }
}
