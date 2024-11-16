using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_RogueTower
{
    [Serializable]
    internal class Dice
    {
        static Random random = new Random();
        // Constantes
        // Champs
        // Propriétés
        // Constructeurs
        // Méthodes
        public static int Lancer(int diceSize = 6)
        {
            return random.Next(1, diceSize + 1);
        }
        public static int LancerPlusieurs(int numberOfDice = 2, int diceSize = 6)
        {
            
            int sum = 0;
            for (int i = 0; i < numberOfDice;i++ )
            {
                sum += random.Next(1, diceSize + 1);
            }
            return sum;
        }
        // Évènements
    }
}
