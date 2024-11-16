using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_RogueTower
{
    [Serializable]
    internal class Item
    {
        // Constantes
        // Champs
        private string _name;
        private int _price;
        private string _description;
        // Propriétés
        public string Name { get => _name; set => _name = value; }
        public int Price { get => _price; set => _price = value; }
        public string Description { get => _description; set => _description = value; }
        // Constructeurs

        public Item(string name, int price, string description = null)
        {
            Name = name;
            Price = price;
            Description = description;
        }
        // Méthodes
        // Événements
    }
}
