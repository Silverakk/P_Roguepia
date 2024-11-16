using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_RogueTower
{
    [Serializable]
    internal class Tower
    {
        // Constantes
        // Champs
        private string _name;
        private string _description;
        private List<Etage> _towerLayout;
            // Faire des listes liste d'étage pour le faire en deux dimensions ? ou travailler avec des arrays, idk list better
        private int _currentLevel; // étage
        private Image _towerImage;
        
        // Propriétés
        internal List<Etage> TowerLayout { get => _towerLayout; set => _towerLayout = value; }
        public int CurrentLevel { get => _currentLevel; set => _currentLevel = value; }
        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }
        public Image TowerImage { get => _towerImage; set => _towerImage = value; }

        // Constructeurs
        public Tower(string name, List<Etage> towerLayout, int currentLevel = 0, string description = null, Image towerImage = null)
        {
            TowerLayout = towerLayout;
            CurrentLevel = currentLevel;
            Name = name;
            Description = description;
            TowerImage = towerImage;
        }

        // Méthodes
        public Etage MonterUnEtage()
        {
            CurrentLevel++;
            return TowerLayout[CurrentLevel];

        }
    }
}
