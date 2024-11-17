using P_RogueTower;
using P_RogueTower.Data;
using P_RogueTower.LivingCreatures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_RogueTower
{
    [Serializable]
    internal class Game
    {
        // Constantes
        // Champs
        private Player _player;
        private Tower _theTower;
        private bool _canChanceAttack;
        private bool _canChanceDefense;
        private int _numberOfCombatRounds;
        private int _numberOfEnnemySlain;
        private Inventory _inventoryBin;
        private bool _gameWon;
        private string _actionDescription;
        private List<string> combatLogs;
        private List<string> donjonsDone;


        // Propriétés
        internal Player Player { get => _player; set => _player = value; }
        internal Tower TheTower { get => _theTower; set => _theTower = value; }
        internal bool CanAttack { get => !GetRoom().AreMonstersDead(); }
        internal bool CanAdvance { get => GetRoom().AreMonstersDead() && GetRoom().IsSkippable; }
        internal bool CanChanceAttack { get => _canChanceAttack; set => _canChanceAttack = value; }
        internal bool CanChanceDefense { get => _canChanceDefense; set => _canChanceDefense = value; }
        public int NumberOfCombatRounds { get => _numberOfCombatRounds; set => _numberOfCombatRounds = value; }
        internal Inventory InventoryBin { get => _inventoryBin; set => _inventoryBin = value; }
        public int NumberOfEnnemySlain { get => _numberOfEnnemySlain; set => _numberOfEnnemySlain = value; }
        public bool GameWon { get => _gameWon; set => _gameWon = value; }
        public string ActionDescription { get => _actionDescription; set => _actionDescription = value; }
        public List<string> CombatLogs { get => combatLogs; set => combatLogs = value; }
        public List<string> DonjonsDone { get => donjonsDone; set => donjonsDone = value; }



        // Constructeurs
        public Game(Player player, Arme arme = null, Item item = null, string name = null, Tower theTower = null, int numberOfEnnemySlain = 0)
        {

            Player = player;
            TheTower = theTower;
            Player.MainDroite = arme;
            if(item != null)
            {
                Player.Inventaire.Add(item);
            }
           
            Player.Name = name;
            NumberOfCombatRounds = 0;
            this.InventoryBin = new Inventory();
            NumberOfEnnemySlain = numberOfEnnemySlain;
            GameWon = false;
            CombatLogs = new List<string>();
            DonjonsDone = new List<string>();
            //Lieu = lieu;
            if(Player.NameRace == "Saurien")
            {
                Player.MainGauche = (DataEquipement.MueSolidifee() as ArmureBrasGauche);
            }
            if (Player.MainDroite.NombreDeMain == 2 && Player.NameRace == "Fée")
            {
                Player.Inventaire.Add(Player.MainDroite as Item);
                Player.MainDroite = null;
            }
        }
        // Méthodes
        

        public bool TestdeChance()
        {
            int diceResult = Dice.LancerPlusieurs();
            bool diceSuccess = diceResult <= Player.Chance;
            CombatLogs.Add($"Vous jetez {diceResult.ToString()}");
            if (diceSuccess) { Player.Chance--; }
            return diceSuccess;
        }
        //_______________________________________________________________________________________________
        public void ReduireDegat() 
        {
            Monstre monstre = GetMonster();
            if (TestdeChance())
            {
                Player.Endurance++;
                CombatLogs.Add("Le test de chance est une réussite, vous regagnez 1 point d'Endurance.");
            }
            else
            {
                Player.Endurance--;
                CombatLogs.Add("Le test de chance est une échec, vous perdez 1 point d'Endurance.");
            }
            CanChanceDefense = false;
        }
        //_______________________________________________________________________________________________
        public void AugmenterDegat()
        {
            Monstre monstre = GetMonster();
            if (TestdeChance())
            {
                string LuckDamagePlusAttempt = "Le test de chance est une réussite, la créature perd 1 point d'Endurance supplémentaire.";
                string LuckBasedMoveAttempt = Player.MainDroite.LuckBasedMove(this);
                monstre.Endurance--;
                if (LuckBasedMoveAttempt != null)
                {
                    LuckDamagePlusAttempt = LuckBasedMoveAttempt;
                }
                CombatLogs.Add(LuckDamagePlusAttempt);
            }
            else
            {
                string LuckDamagePlusAttempt = "Le test de chance est un échec, la créature regagne 1 point d'Endurance supplémentaire.";
                monstre.Endurance++;
                if (monstre.Endurance <= 0)
                {

                    MonsterDeath(monstre);
                }
                CanChanceAttack = false;
                CombatLogs.Add($"{LuckDamagePlusAttempt}");
            }
        }
        //_______________________________________________________________________________________________
        public void CombatRound1v1()
        {
            NumberOfCombatRounds++;
            Monstre monstre = GetMonster();
            int playerDiceThrow = Player.JetdHabilite();
            int monsterDiceThrow = monstre.JetdHabilite();
            if (!GetRoom().Light && !Player.IsLighted)
            {
                playerDiceThrow -= 1;
            }
            CanChanceAttack = false;
            CanChanceDefense = false;
            CombatLogs.Add($"Tour {NumberOfCombatRounds}");
            CombatLogs.Add($"{Player.Name} jet {playerDiceThrow} ");
            CombatLogs.Add($"{GetMonster().Name} jet {monsterDiceThrow}");
            // Player attacks
            if (playerDiceThrow > monsterDiceThrow)
            {
                if (Player.MainDroite != null)
                {
                    if (!monstre.IsMagic || monstre.IsMagic && (Player.IsMagic || Player.MainDroite.IsMagic))
                    {
                        CombatLogs.Add($"{Player.Name} inflige {Player.MainDroite.Puissance} !\n");
                        monstre.Endurance -= Player.MainDroite.Puissance;
                        Player.MainDroite.WeaponMove(this);
                        if (monstre.Endurance >= 0)
                        {
                            CanChanceAttack = true;
                        };
                    }
                    else
                    {
                        CombatLogs.Add($"{GetMonster().Name} ne prend aucun dégât.\n");
                    }
                }
            }
            // Monster Attack
            else if (playerDiceThrow < monsterDiceThrow)
            {
                CombatLogs.Add($"{GetMonster().Name} inflige {GetMonster().Puissance} !\n");
                if (Player.MainGauche != null)
                {
                    string blockAttempt = Player.MainGauche.Block(this);
                    if (blockAttempt != null)
                    {
                        CombatLogs.Add(blockAttempt);
                    }
                }

                Player.Endurance -= monstre.Puissance;
                CanChanceDefense = true;
            }
            else
            {
                CombatLogs.Add($"égalité\n");
            }
            MonsterDeath(monstre);
        }

        private void MonsterDeath(Monstre monstre)
        {
            if (monstre.Endurance <= 0)
            {
                CombatLogs.Add($"{GetMonster().Name} meurt.");
                GetRoom().RemoveMonster();
                MonsterDropOnDeath(monstre);
                CanChanceAttack = false;
                CanChanceDefense = false;
                if (GetRoom().AreMonstersDead() == true)
                {
                    NumberOfCombatRounds = 0;
                }
            }
        }

        private void MonsterDropOnDeath(Monstre monstre)
        {
            NumberOfEnnemySlain++;
            Player.Lyre += monstre.MoneyDrop;
            
            
            if (monstre.Inventaire != null)
            {
                foreach (Item i in monstre.Inventaire)
                {
                    CombatLogs.Add($"la créature avait {i.Name}-");
                    Player.Inventaire.Add(i);
                }
            }
            CombatLogs.Add($"Vous recevez {monstre.MoneyDrop} lyres.\n");
        }

        //_______________________________________________________________________________________________
        public void Fuir()
        {
            if (TestdeChance() && GetMonster().CanBeFleeFrom)
            {
                GetRoom().MonsterPool.Clear();
                CanChanceAttack = false;
                CanChanceDefense = false;
            }
            else
            {
                Player.Endurance -= GetMonster().Puissance;

            }
            Avancer();
            
        }
        //_______________________________________________________________________________________________
        public Monstre GetMonster()
        {
            Lieu currentRoom = GetRoom();
            return currentRoom.MonsterPool[0];
        }
        //_______________________________________________________________________________________________
        public bool CanBeFlee()
        {
            Lieu currentRoom = GetRoom();
            if (currentRoom.MonsterPool.Count > 0)
            {
                return GetMonster().CanBeFleeFrom;
            }
            else
            {
                return true;
            }
        }
        //_______________________________________________________________________________________________
        public void SwitchNextRoomId()
        {
            Lieu currentLieu = GetRoom();
            int temp = currentLieu.NextRoomId;
            currentLieu.NextRoomId = currentLieu.SecondNextRoomId;
            currentLieu.SecondNextRoomId = temp;
        }
        public Lieu GetRoom()
        {
            Etage currentLevel = GetLevel();

            foreach(Lieu lieu in currentLevel.LevelLayout)
            {
                if(lieu.CurrentRoomId == currentLevel.CurrentRoom)
                {
                    return lieu;
                }
            }
            return currentLevel.LevelLayout[0];


        }
        //_______________________________________________________________________________________________

        public Etage GetLevel()
        {
            return TheTower.TowerLayout[TheTower.CurrentLevel];
        }
        public bool IsTheEndOfTower()
        {
            Etage currentLevel = GetLevel();
            return TheTower.CurrentLevel == TheTower.TowerLayout.Count() - 1 && currentLevel.CurrentRoom == currentLevel.LevelLayout.Count() - 1;
        }
        //_______________________________________________________________________________________________

        public void Avancer()
        {

            Etage currentLevel = GetLevel();
            HasWon(IsTheEndOfTower());
            // Le joueur se déplace sur la liste de lieu
            if(GetRoom().IsStairs == true && !IsTheEndOfTower())
            {                
                TheTower.CurrentLevel++;
                
            }
            else if(!IsTheEndOfTower())
            {
                currentLevel.CurrentRoom = GetRoom().NextRoomId;

            }
            
            DecreaseConsummableTimeCounter();
        }

        private void DecreaseConsummableTimeCounter()
        {
            foreach (Item item in InventoryBin)
            {
                if (item is Consummable)
                {
                    (item as Consummable).TimeCounter--;
                    if ((item as Consummable).HasTimeCounter && (item as Consummable).TimeCounter <= 0)
                    {
                        (item as Consummable).EndOfTimeCounter(this);
                        Player.Inventaire.Remove(item);
                    }
                }
            }
        }

        private void HasWon(bool theEnd)
        {
            if (theEnd && GameWon == false)
            {
                GameWon = true;
                donjonsDone.Add(TheTower.Name);
                VictoryScreen victoryscreen = new VictoryScreen();
                victoryscreen.ShowDialog();
            }
        }

        //_______________________________________________________________________________________________
        public bool IsPlayerAlive()
        {
            return Player.Endurance > 0;
        }
        //_______________________________________________________________________________________________
        public void UseItem(Item item)
        {
            
            if (item is Consummable)
            {
                (item as Consummable).Consume(this);
                (item as Consummable).NumberOFUsage--;
                if ((item as Consummable).NumberOFUsage <= 0)
                {
                    if ((item as Consummable).HasTimeCounter)
                    {
                        this.InventoryBin.Add(item);
                    }
                    Player.Inventaire.Remove(item);
                }
                if (GetMonster().Endurance <= 0)
                {

                    MonsterDeath(GetMonster());
                }
            }

            bool raceExceptions = Player.NameRace != "Orc" && Player.NameRace != "Fée";


            if (item is Arme)
            {
                if ((item as Arme).NombreDeMain == 1 && raceExceptions)
                {
                    Player.Inventaire.Remove(item);
                    if (Player.MainDroite != null)
                    {
                        Player.Inventaire.Add(Player.MainDroite);
                    }
                    Player.MainDroite = item as Arme;
                }
                else if ((item as Arme).NombreDeMain == 2 && raceExceptions)
                {
                    Player.Inventaire.Remove(item);
                    if (Player.MainDroite != null)
                    {
                        Player.Inventaire.Add(Player.MainDroite);
                        
                    }
                    Player.MainDroite = item as Arme;
                    
                    if (Player.MainGauche != null)
                    {
                        Player.Inventaire.Add(Player.MainGauche);
                        Player.MainGauche = null;
                    }
                }
                // Orc Main droite _____________________________________
                if (Player.NameRace == "Orc")
                {
                    Player.Inventaire.Remove(item);
                    if (Player.MainDroite != null)
                    {
                        Player.Inventaire.Add(Player.MainDroite);
                    }
                    Player.MainDroite = item as Arme;
                }
                // Fée Main droite _____________________________________
                if (Player.NameRace == "Fée" && (item as Arme).NombreDeMain == 1)
                {
                    Player.Inventaire.Remove(item);
                    if (Player.MainDroite != null)
                    {
                        Player.Inventaire.Add(Player.MainDroite);

                    }
                    Player.MainDroite = item as Arme;

                    if (Player.MainGauche != null)
                    {
                        Player.Inventaire.Add(Player.MainGauche);
                        Player.MainGauche = null;
                    }
                }
            }
            
            
            if (item is ArmureBrasGauche && raceExceptions)
            {

                Player.Inventaire.Remove(item);
                if (Player.MainGauche != null)
                {
                    Player.Inventaire.Add(Player.MainGauche);
                }
                Player.MainGauche = item as ArmureBrasGauche;
                if (Player.MainDroite != null)
                {
                    if(Player.MainDroite.NombreDeMain == 2)
                    {
                        Player.Inventaire.Add(Player.MainDroite);
                        Player.MainDroite = null;
                        
                    }
                }
            }
            
           
            // Orc Main gauche _____________________________________

            if (item is ArmureBrasGauche && Player.NameRace == "Orc")
            {

                Player.Inventaire.Remove(item);
                if (Player.MainGauche != null)
                {
                    Player.Inventaire.Add(Player.MainGauche);
                }
                Player.MainGauche = item as ArmureBrasGauche;

            }
            // Féee Main gauche
            if (item is ArmureBrasGauche && Player.NameRace == "Fée")
            {
                

                    Player.Inventaire.Remove(item);
                if (Player.MainGauche != null)
                {
                    Player.Inventaire.Add(Player.MainGauche);
                }
                Player.MainGauche = item as ArmureBrasGauche;
                if (Player.MainDroite != null)
                {
                    Player.Inventaire.Add(Player.MainDroite);
                    Player.MainDroite = null;

                }

            }
        }
        //_______________________________________________________________________________________________
        public void UseAction()
        {
            Lieu currentRoom = GetRoom();
            if (currentRoom is Actionable)
            {
                ActionDescription = (currentRoom as Actionable).ActionAndDescription(this);
            }
        }

        //_______________________________________________________________________________________________
        public void RemoveShieldOnClick()
        {
            if(Player.MainGauche != null)
            {
                Player.Inventaire.Add(Player.MainGauche);
                Player.MainGauche = null;
            }
            
        }
        //_______________________________________________________________________________________________
        public void RemoveWeaponOnClick()
        {
            
            if (Player.MainDroite != null)
            {
                Player.Inventaire.Add(Player.MainDroite);
                Player.MainDroite = null;
            }

        }
        //_______________________________________________________________________________________________

        public bool CanAvanceBtnCheck()
        {
            bool btnCheck = IsPlayerAlive() && !GameWon;
            return CanAdvance || CanBeFlee() && GetRoom().IsSkippable && btnCheck;
        }
        public bool CanAttaqueBtnCheck()
        {
            bool btnCheck = IsPlayerAlive() && !GameWon;
            return CanAttack && btnCheck;
        }

        public bool CanActionBtnCheck()
        {
            if(GetRoom() is Actionable)
            {
                (GetRoom() as Actionable).BecomeActionableWhenAllCreaturesAreDead(this);
            }
            bool btnCheck = IsPlayerAlive() && !GameWon;
            return GetRoom().IsActionable && btnCheck;
        }
        public bool CanChanceBtnCheck()
        {
            
            bool btnCheck = IsPlayerAlive() && !GameWon;            
            return (CanChanceDefense || CanChanceAttack ) && btnCheck;
        }




        // Événements
    }
}
