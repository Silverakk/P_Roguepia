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
        
        public static Lieu CouloirTest(int currentId, int nextIdRoom, int secondNextIdRoom) 
        { return new Lieu(currentId, nextIdRoom, secondNextIdRoom, "un couloir", "Un long couloir étroit.", DataMonsters.Getdtest_Monsters()); }
        public static Lieu dtest_Couloir() { return new Lieu(4, 5, 5, "un couloir", "Un long couloir étroit.", DataMonsters.Getdtest_Monsters()); }
        public static Lieu dtest_PetitePieceVide() { return new Lieu(6, 7, 7, "une piece carrée", "Une petite salle vide.", DataMonsters.GetFirstTestBoss()); }
        public static Lieu dtest_Vide = new Lieu(0,0,0,"Sommet du donjon test","Sommet du donjon test, merci d'avoir si tout fonctionne bien.");
        public static Lieu dtest_CouloirAvecPorte = new Lieu(5,6,0, "Un couloir", "un long couloir étroit avec une grande porte porte sur le coté.");
        public static Lieu dtest_PorteDEntre = new Lieu(0,1,0,"porte d'entrée", "La porte d'entrée d'un donjon de test.");
        public static Lieu dtest_Escalier = new Lieu(7,0,0,"un escalier", "Un long escalier en colimason.",null,true,false,true,true);
        public static Lieu dtest_Fontaine() { return new Fountaine(1, 2, 7); }
        public static Lieu dtest_CouloirAvecPorte1 = new Lieu(3,4,0, "Un couloir", "un long couloir étroit avec une petite porte sur le coté.");
        public static Lieu CouloirRandom(int currentId, int nextIdRoom, int secondNextIdRoom)
        {
            Random rdn = new Random();
            List<Lieu> couloirPool = new List<Lieu>() {
                new Lieu(currentId, nextIdRoom, secondNextIdRoom, "un couloir", "un long couloir étroit", DataMonsters.Getdtest_Monsters()
                )};

            return couloirPool[rdn.Next(0, couloirPool.Count())];
        }
        
        // Tour tutrorial__________________________________________________________________________________________________________________________
        // Tools __________________________________________________________________________________________________________________________________
        public static List<Lieu> GetAllRooms()
        {
            return new List<Lieu> { dtest_Vide };
        }
        public static List<Lieu> Rien()
        {
            return new List<Lieu> { dtest_Vide };
        }
        // Tour tutrorial__________________________________________________________________________________________________________________________
        public static Lieu dtuto_devantlentree(int currentId, int nextIdRoom, int secondNextIdRoom)
        {
            return new Lieu(currentId, nextIdRoom, secondNextIdRoom, "Devant le château", "Devant vous se tient le château tutoriel, la famille tutorielle était connue dans la région car ils étaient les anciens seigneurs de ces lieux et étaient cruels. Si vous souhaitez explorer ses lieux, avancez.");
        }
        public static Lieu dtuto_Entree(int currentId, int nextIdRoom, int secondNextIdRoom)
        {
            return new Lieu(currentId, nextIdRoom, secondNextIdRoom, "l'entrée du château", "Vous voici dans la cour d'un château délabré et en ruine. La végétation a repris ces lieux et les reliefs du bâtiment font penser à monticule de pierre. Un pont improvisé se tient au dessus d'un fosse sans fond entourant la structure.", DataMonsters.GetBoeuf());
        }
        public static PontTutorielle dtuto_pont(int currentId, int nextIdRoom, int secondNextIdRoom)
        {
            return new PontTutorielle(currentId, nextIdRoom, secondNextIdRoom);
        }
        public static KillZoneTest TestRoomIsLuckable(int currentId, int nextIdRoom, int secondNextIdRoom) { return new KillZoneTest(currentId, nextIdRoom, secondNextIdRoom); }



        // Donjon test ____________________________________________________________________________________________________________________________
        public static List<Lieu> SimpleEtage()
        {
            return new List<Lieu>
            {
                dtest_PorteDEntre,
                dtest_Fontaine(),
                CouloirTest(2, 3, 3),
                dtest_CouloirAvecPorte,
                dtest_Couloir(),
                dtest_CouloirAvecPorte1,
                dtest_PetitePieceVide(),
                dtest_Escalier,
            };
        }
        public static List<Lieu> SommetDuDonjonTest()
        {
            return new List<Lieu>
            {
                dtest_Vide
            };
        }


        // Tour tutrorial__________________________________________________________________________________________________________________________
        public static List<Lieu> PremierEtageDeLaTourTutorial()
        {
            return new List<Lieu>
            {
                dtuto_devantlentree(0,1,0),
                dtuto_pont(1,2,0),
                dtuto_Entree(2,3,0),
                
            };
        }


    }
    [Serializable]
    internal class Fountaine : Actionable
    {
        int actionNumber = 1;
        public Fountaine(int currentId, int nextIdRoom, int secondNextIdRoom) : base(currentId, nextIdRoom, secondNextIdRoom, "Fontaine", null, null, false, true)
        {

        }
        public override void BecomeActionableWhenAllCreaturesAreDead(Game game)
        {
            if (game.GetRoom().AreMonstersDead())
            {
                this.IsActionable = true;
            }
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
            actionNumber++;
            if (actionNumber >= 3)
            {
                actionNumber = 2;
            }

            
            
            return description;
            
        }
        
    }
    [Serializable]
    internal class KillZoneTest : Actionable
    {
        public KillZoneTest(int currentId, int nextIdRoom, int secondNextIdRoom) : base(currentId, nextIdRoom, secondNextIdRoom,"Kill zone test", null, null, false, true, true)
        {

        }
        public override string ActionAndDescription(Game game)
        {
            game.Player.Endurance -= 100;
            game.GetRoom().IsActionable = false;
            return "KILLL ZONE";

        }
    }
    [Serializable]
    internal class PontTutorielle : Actionable
    {
        int actionNumber = 1;
        public PontTutorielle(int currentId, int nextIdRoom, int secondNextIdRoom) : base(currentId, nextIdRoom, secondNextIdRoom, "Au bout du pont", "Au bout du pont, en dessous de l'arche de la porte d'entrée se trouve une statue assise vous regardant. Utiliser le bouton d'action pour intéragir avc elle.", null, true, true, true)
        {

        }
        public override string ActionAndDescription(Game game)
        {
            game.GetRoom().Description = null;
            string description = string.Empty;
            if (actionNumber == 1)
            {
                description = "Aussitôt que vous prononcez un mot, la statue se lève et s'approche de vous. Elle vous dit de baisser votre arme. Vous pouvez faire en cliquant sur le label de votre arme en bas à droite. ";
            }
            if (actionNumber == 2)
            {
                if(game.Player.MainDroite != null)
                {
                    game.GetRoom().MonsterPool.Add(DataMonsters.StatueRuine());
                    description = "La statue s'eclâme \"Insolant !\" et se précipite sur vous. ";
                    game.GetRoom().IsActionable = false;

                }
                else
                {
                    game.Player.Inventaire.Add(DataItems.PoudreMagique()) ;
                    description = "La statue vous remercie et dit  \"Si vous voulez continuer sans mourir, je vous conseil de fuir le boeuf doré dans la cour, mais chaque jet de chance réussi coûte. C'est une créature magique causant des ennuis et je ne pense pas que vous pourrez le blesser, voici de la poudre magique si vous pensez essayer de l'abattre.\"";
                }
            }

            actionNumber++;
            return description;

        }
    }
}
