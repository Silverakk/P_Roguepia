using P_RogueTower.Data;
using P_RogueTower.LivingCreatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_RogueTower
{
    [Serializable]
    internal class Player : LivingCreature
    {
        // Constantes
        // Champs
        private int _baseChance;
        private int _chance;
        private string _nameRace;
        private int _lyre;
        private bool _isLighted;

        // Propriétés
        public int Chance
        {
            get => _chance;
            set
            {
                if (value <= _baseChance)
                    _chance = value;
                else
                    _chance = _baseChance;
            }
        }
        public string NameRace { get => _nameRace; set => _nameRace = value; }
        public int BaseChance { get => _baseChance; set => _baseChance = value; }
        public int Lyre { get => _lyre; set => _lyre = value; }
        public bool IsLighted { get => _isLighted; set => _isLighted = value; }


        // Constructeurs
        public Player(string nameRace, int chance, int endurance, int habilite, Inventory sac = null, bool isMagic = false, int lyre = 10, string descriptionOfLivingCreature = null, bool isLighted = false)
        {
            BaseChance = chance;
            BaseEndurance = endurance;
            BaseHabilite = habilite;
            Chance = chance;
            NameRace = nameRace;
            Endurance = endurance;
            Habilite = habilite;
            IsMagic = isMagic;
            Lyre = lyre;
            IsLighted = isLighted;
            DescriptionOfLivingCreature = descriptionOfLivingCreature;
            if (sac != null)
            {
                this.Inventaire = sac;
            }
            else
            {
                this.Inventaire = new Inventory();
            }
            this.Inventaire.Add(DataItems.Torche());
            this.Inventaire.Add(DataItems.Ration());
            this.Inventaire.Add(DataItems.Ration());
            
            
        }
        // Méthodes
        // Événements
    }
}
