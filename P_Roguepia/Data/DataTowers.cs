using P_Roguepia.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace P_RogueTower.Data
{
    static class DataTowers
    {
        public static Tower TestDunjon()
        {
            return new Tower("Donjon de Test", DataEtages.TestDunjon(), 0, "Test", Resources.whiteroom);
        }
        public static Tower TourTutorielle()
        {
            return new Tower("Château Tutoriel", DataEtages.ChateauTutoriel(), 0, "C'est un donjon didacticielle dans le but de vous apprendre les bases du jeu, n'appuyez pas sur les boutons trop vite et vous apprendrez surement quelque chose", Resources.defaultscreen);
        }
        public static Tower Vide = new Tower("Vide", DataEtages.TestDunjon(), 0);
        public static List<Tower> GetAllDunjons()
        {
            return new List<Tower> { TourTutorielle() };
        }
        public static List<Tower> GetNewGamePlusDunjons()
        {
            return new List<Tower> { TestDunjon(), TourTutorielle() };
        }
    }
    
}
