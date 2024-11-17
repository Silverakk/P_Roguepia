using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_RogueTower.Data
{
    class DataLieux2
    {

        public DataLieux2()
        {

        }
        // Donjon test ____________________________________________________________________________________________________
        public Lieu PetitePieceVide = new Lieu(6,7,7,"une piece carrée", "Une petite salle vide", DataMonsters.GetFirstTestBoss());
        public  Lieu CouloirTest()
        {
            return new Lieu(2, 3, 3, "un couloir", "un long couloir étroit", DataMonsters.Getdtest_Monsters());
        }
        public Lieu Couloir = new Lieu(4, 5, 5, "un couloir", "un long couloir étroit", DataMonsters.Getdtest_Monsters());
        public Lieu CouloirRandom(int currentId, int nextIdRoom, int secondNextIdRoom) 
        {
            Random rdn = new Random();
            List<Lieu> couloirPool = new List<Lieu>() { new Lieu(currentId, nextIdRoom, secondNextIdRoom, "un couloir", "un long couloir étroit", DataMonsters.Getdtest_Monsters())};
             
            return couloirPool[rdn.Next(0,couloirPool.Count())];
        }
        public Lieu CouloirAvecPorte1 = new Lieu(3, 4, 4, "un couloir avec une porte sur le coté", "un long couloir étroit avec une porte sur le coté");
        public Lieu CouloirAvecPorte = new Lieu(5, 6, 6, "un couloir avec une porte sur le coté", "un long couloir étroit avec une porte sur le coté");
        public Lieu PorteDEntre = new Lieu(0, 1, 1,"porte d'entrée", "La porte d'entrée d'un donjon de test");
        public Lieu Escalier = new Lieu(7,0,0,"un escalier", "un long escalier en colimason",null,true,false,true,true);
        public Lieu Fontaine = new Fountaine2();
        public Lieu Vide = new Lieu(0,0,0,"Sommet du donjon test","sommet du donjon test");

        public  List<Lieu> SimpleEtage()
        {   
            return new List<Lieu>
            {
                PorteDEntre,
                Fontaine,
                CouloirTest(),
                CouloirAvecPorte,
                Couloir,
                CouloirAvecPorte1,
                PetitePieceVide,
                Escalier, 
            };
        }
        public  List<Lieu> SommetDuDonjonTest()
        {
            return new List<Lieu>
            {
                Vide
            };
        }
        // Tour tutrorial__________________________________________________________________________________________________________________________
        
        public  Lieu GetRandomRoom(List<Lieu> poolRoom1)
        {

            Random rand = new Random();

            Lieu randomChoice;
            
            if (poolRoom1 == null)
            {
                randomChoice = GetAllRooms()[rand.Next() % GetAllRooms().Count()];
            }
            else
            {
                randomChoice = poolRoom1[rand.Next() % poolRoom1.Count()];
            }


            return randomChoice;
        }
        public  List<Lieu> PremierEtageDeLaTourTutorial()
        {
            return new List<Lieu>
            {

            };
        }
        // tools --------------------------------------------------------------------------
        public  List<Lieu> GetAllRooms()
        {
            return new List<Lieu> { Vide };
        }
        public  List<Lieu> Rien()
        {
            return new List<Lieu> { Vide };
        }

    }

    [Serializable]
    internal class Fountaine2 : Actionable
    {
        int actionNumber = 1;
        public Fountaine2() : base(1, 2, 7, "Fontaine", null, null, false, true, true)
        {

        }

        public override string ActionAndDescription(Game game)
        {

            string description = string.Empty;
            if (actionNumber == 1)
            {
                game.Player.Endurance += 5;

                description = "Vous buvez dans la fontaine et vous refairchissez" +
                    ", Vous voyez au fond de la fontaine un passage, si vous utilisez le bouton d'action vous prendrez ce chemin";

            }
            else if (actionNumber == 2)
            {

                game.SwitchNextRoomId();
                description = "Utilisez le bouton d'action si vous décidez de reprendre votre chemin originel";
            }
            else if (actionNumber == 3)
            {
                
                game.SwitchNextRoomId();
                
                description = "Vous voyez au fond de la fontaine un passage, si vous utilisez le bouton d'action vous changerez votre trajectoire";

            }
            if (actionNumber == 3)
            {
                actionNumber = 1;
            }

            actionNumber++;
            
            return description;
            
        }
    }

}
