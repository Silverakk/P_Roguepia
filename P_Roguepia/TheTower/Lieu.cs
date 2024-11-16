using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_RogueTower
{
    [Serializable]
    internal class Lieu
    {
        // Constantes
        // Champs
        private string _name;
        private string _description;
        private bool _light;
        private int _numberOfMobs;
        private List<Monstre> _monsterPool;
        private bool _IsActionable;
        private bool _isSkippable;
        private int _currentRoomId;
        private int _nextRoomId;
        private int _secondNextRoomId;
        private bool _isStairs;



        // Propriétés
        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }
        public bool Light { get => _light; set => _light = value; }
        public int NumberOfMobs { get => _numberOfMobs; set => _numberOfMobs = value; }
        internal List<Monstre> MonsterPool { get => _monsterPool; set => _monsterPool = value; }
        public bool IsActionable { get => _IsActionable; set => _IsActionable = value; }
        public bool IsSkippable { get => _isSkippable; set => _isSkippable = value; }
        public int CurrentRoomId { get => _currentRoomId; set => _currentRoomId = value; }
        public int NextRoomId { get => _nextRoomId; set => _nextRoomId = value; }
        public int SecondNextRoomId { get => _secondNextRoomId; set => _secondNextRoomId = value; }
        public bool IsStairs { get => _isStairs; set => _isStairs = value; }


        // Constructeurs
        public Lieu(
            int currentRoomId, int nextRoomId, int secondNextRoomId,
            string name, string description = null,
            List<Monstre> monsterPool = null,
            bool light = true, 
            bool isActionable = false, 
            bool isSkippable = true, 
            bool isStairs = false)
        {
            Name = name;
            Description = description;
            Light = light;
            MonsterPool = monsterPool;
            IsActionable = isActionable;
            IsSkippable = isSkippable;
            if (monsterPool == null)
            {
                MonsterPool = new List<Monstre>();
            }
            CurrentRoomId = currentRoomId;
            NextRoomId = nextRoomId;
            SecondNextRoomId = secondNextRoomId;
            IsStairs = isStairs;
        }
        // Méthodes
        public void RemoveMonster()
        {
            MonsterPool.RemoveAt(0);
        }
        public bool AreMonstersDead()
        {
            return MonsterPool.Count() == 0;
        }
        
        


        // Événements
    }
}
