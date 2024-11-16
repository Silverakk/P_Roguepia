using P_RogueTower.LivingCreatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace P_RogueTower
{
    [Serializable]
    internal class LivingCreature
    {
        // Constantes
        // Champs
        private Inventory _inventaire;
        private string _name;
        protected int _endurance;
        protected int _habilite;
        private ArmureBrasGauche _mainGauche;
        private Arme _mainDroite;
        private bool _isMagic;
        private int _baseEndurance;
        private int _baseHabilite;
        private string _descriptionOfLivingCreature;
        // Propriétés

        public int Habilite { get => _habilite; set => _habilite = value; }
        public int Endurance
        {
            get => _endurance;
            set
            {
                if (value <= _baseEndurance)
                    _endurance = value;
                else
                    _endurance = _baseEndurance;
            }
        }
        internal bool IsMagic { get => _isMagic; set => _isMagic = value; }
        internal Inventory Inventaire { get => _inventaire; set => _inventaire = value; }
        internal ArmureBrasGauche MainGauche { get => _mainGauche; set => _mainGauche = value; }
        internal Arme MainDroite { get => _mainDroite; set => _mainDroite = value; }
        internal string Name { get => _name; set => _name = value; }
        internal int BaseEndurance { get => _baseEndurance; set => _baseEndurance = value; }
        internal int BaseHabilite { get => _baseHabilite; set => _baseHabilite = value; }
        public string DescriptionOfLivingCreature { get => _descriptionOfLivingCreature; set => _descriptionOfLivingCreature = value; }

        // Constructeurs
        // Méthodes
        public int JetdHabilite()
        {
            return Dice.LancerPlusieurs() + Habilite;
        }
        public bool TestdHabilite()
        {
            int diceResult = Dice.LancerPlusieurs();
            bool diceSuccess = diceResult <= Habilite;
            return diceSuccess;
        }
        // Événements
    }
}
