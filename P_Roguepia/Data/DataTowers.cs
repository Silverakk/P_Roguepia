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
            return new Tower("Tour Tutorielle", DataEtages.Vide(), 0, "C'est un donjon didacticielle dans le but de vous apprendre les bases du jeu, n'appuyez pas sur les boutons trop vite", Resources.defaultscreen);
        }
        public static Tower Vide = new Tower("Vide", DataEtages.TestDunjon());
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
