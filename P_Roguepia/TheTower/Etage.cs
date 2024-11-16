using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace P_RogueTower
{
    [Serializable]
    internal class Etage
    {
        // Constantes
        // Champs
        private string _name;
        private string _description;
        private int _currentRoom;
        private List<Lieu> _levelLayout;


        // Propriétés
        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }

        internal List<Lieu> LevelLayout { get => _levelLayout; set => _levelLayout = value; }

        public int CurrentRoom { get => _currentRoom; set => _currentRoom = value; }


        // Constructeurs
        public Etage(string name, string description, List<Lieu> levelLayout, int currentRoom = 0)
        {
            Name = name;
            Description = description;
            LevelLayout = levelLayout;

            CurrentRoom = currentRoom;
        }
        // Méthodes

        // Événements
    }
}
