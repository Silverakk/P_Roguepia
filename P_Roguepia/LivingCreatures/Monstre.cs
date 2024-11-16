using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_RogueTower
{
    [Serializable]
    internal class Monstre : LivingCreature
    {
        // Constantes
        // Champs
        
        private int _puissance;
        private int _lyreDrop;
        private Image _mobPicture;
        private bool _canBeFleeFrom;
        private int _moneyDrop;
        private int _ChanceDrop;
        // Propriétés
        public int Puissance { get => _puissance; set => _puissance = value; }
        public int LyreDrop { get => _lyreDrop; set => _lyreDrop = value; }
        public Image MobPicture { get => _mobPicture; set => _mobPicture = value; }
        public bool CanBeFleeFrom { get => _canBeFleeFrom; set => _canBeFleeFrom = value; }
        public int MoneyDrop { get => _moneyDrop; set => _moneyDrop = value; }
        public int ChanceDrop { get => _ChanceDrop; set => _ChanceDrop = value; }

        // Constructeurs
        public Monstre(string name, int puissance, int endurance, int habilite, bool isMagic = false, int lyreDrop = 0, Inventory sac = null, Image mobPicture = null, bool canBeFleeFrom = true, string descriptionOfLivingCreature = null, int moneyDrop = 0, int chanceDrop = 0)
        {
            Name = name;
            BaseEndurance = endurance;
            BaseHabilite = habilite;
            Puissance = puissance;
            Endurance = endurance;
            Habilite = habilite;
            IsMagic = isMagic;
            LyreDrop = lyreDrop;
            MobPicture = mobPicture;
            DescriptionOfLivingCreature = descriptionOfLivingCreature;
            MoneyDrop = moneyDrop;
            ChanceDrop = chanceDrop;

            if (sac != null)
            {
                this.Inventaire = sac;
            }
            else
            {
                this.Inventaire = new Inventory();
            }
            CanBeFleeFrom = canBeFleeFrom;
            
           
        }
        // Méthodes
        // Événements
    }
}
