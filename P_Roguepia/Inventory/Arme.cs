using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace P_RogueTower.LivingCreatures
{
    [Serializable]
    internal class Arme : Equipement
    {

        private int _puissance;
        private int _malusdHabilite;
        private int _nombreDeMain;
        private bool _isMagic;
        public int Puissance { get => _puissance; set => _puissance = value; }
        public int MalusdHabilite { get => _malusdHabilite; set => _malusdHabilite = value; }
        public int NombreDeMain { get => _nombreDeMain; set => _nombreDeMain = value; }
        public bool IsMagic { get => _isMagic; set => _isMagic = value; }

        public Arme(int nombreDeMain, int puissance, int malusdHabilite, string name, int price, string description = null, bool isMagic = false) : base(name, price)
        {
            Puissance = puissance;
            MalusdHabilite = malusdHabilite;
            Description = description;
            NombreDeMain = nombreDeMain;
            IsMagic = isMagic;
        }
        public virtual string WeaponMove(Game game)
        {
            return null;
        }
        public virtual string LuckBasedMove(Game game)
        {
            return null;
        }

    }



}
