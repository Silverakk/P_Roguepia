using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_RogueTower.Data
{
    static class DataLieux
    {
        // Donjon test ____________________________________________________________________________________________________
        public static Lieu PetitePieceVide = new Lieu(6,7,7,"une piece carrée", "Une petite salle vide", DataMonsters.GetFirstTestBoss());
        public static Lieu CouloirTest()
        {
            return new Lieu(2, 3, 3, "un couloir", "un long couloir étroit", DataMonsters.GetFirstFloorMonsters());
        }
        public static Lieu Couloir = new Lieu(4, 5, 5, "un couloir", "un long couloir étroit", DataMonsters.GetFirstFloorMonsters());
        public static Lieu CouloirRandom(int currentId, int nextIdRoom, int secondNextIdRoom) 
        {
            Random rdn = new Random();
            List<Lieu> couloirPool = new List<Lieu>() { new Lieu(currentId, nextIdRoom, secondNextIdRoom, "un couloir", "un long couloir étroit", DataMonsters.GetFirstFloorMonsters())};
             
            return couloirPool[rdn.Next(0,couloirPool.Count())];
        }
        public static Lieu CouloirAvecPorte1 = new Lieu(3, 4, 4, "un couloir avec une porte sur le coté", "un long couloir étroit avec une porte sur le coté");
        public static Lieu CouloirAvecPorte = new Lieu(5, 6, 6, "un couloir avec une porte sur le coté", "un long couloir étroit avec une porte sur le coté");
        public static Lieu PorteDEntre = new Lieu(0, 1, 1,"porte d'entrée", "La porte d'entrée d'un donjon de test");
        public static Lieu Escalier = new Lieu(7,0,0,"un escalier", "un long escalier en colimason",null,true,false,true,true);
        public static Lieu Fontaine = new Fountaine();
        public static Lieu Vide = new Lieu(0,0,0,"Sommet du donjon test","sommet du donjon test");

        public static List<Lieu> SimpleEtage()
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
        public static List<Lieu> SommetDuDonjonTest()
        {
            return new List<Lieu>
            {
                Vide
            };
        }
        // Tour tutrorial__________________________________________________________________________________________________________________________
        
        public static Lieu GetRandomRoom(List<Lieu> poolRoom1)
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
        public static List<Lieu> PremierEtageDeLaTourTutorial()
        {
            return new List<Lieu>
            {

            };
        }
        // tools --------------------------------------------------------------------------
        public static List<Lieu> GetAllRooms()
        {
            return new List<Lieu> { Vide };
        }
        public static List<Lieu> Rien()
        {
            return new List<Lieu> { Vide };
        }

    }
    [Serializable]
    internal class Fountaine : Actionable
    {
        int actionNumber = 1;
        public Fountaine() : base(1, 2, 7, 1,"Fontaine", null, null, false, true, true)
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
