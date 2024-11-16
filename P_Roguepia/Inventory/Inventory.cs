using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_RogueTower
{
    [Serializable]
    internal class Inventory : List<Item>
    {
        // Constantes
        // Champs
        // Propriétés
        // Constructeurs
        // Méthodes
        public void RetirerObjet(Item item)
        {
            this.Remove(item);
        }
        // Événements
    }
}
