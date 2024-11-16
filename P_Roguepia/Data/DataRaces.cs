using P_RogueTower.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace P_RogueTower
{
    static class DataRaces
    {
        public static Player Vide() 
        {
            return new Player("Vide", 0, 0, 0, null, false, 0, $" Vide");
        }  
        
        public static Player Humain() 
        {
            return new Player("Humain", 10, 12, 8, null, false, 15, $" Les humains sont les plus présents \ncommence avec 12 points d'Endurance, 10 points de chance et 8 points d'habilité et 5 lyres supplémentaires");
        }
        public static Player Elfe()
        {
            return new Player("Elfe", 8, 10, 9, new Inventory() { DataItems.PoudreMagique() }, false,10, "Hehehe\ncommence avec 10 points d'Endurance, 8 points de chance et 9 points d'habilité et de la poudre magique");
        }
        public static Player Nain() 
        {
           return new Player("Nain", 11, 14, 7, new Inventory() { DataItems.Rubis() }, false, 10, "Hehehe\ncommence avec 14 points d'Endurance, 11 points de chance et 7 points d'habilité et un rubis");
        }
        public static Player Saurien()
        {
            return new Player("Saurien", 9, 10, 8, new Inventory() { DataEquipement.MueSolidifee() }, false, 10, "Homme lézard des berges européennes\ncommence avec 10 points d'Endurance, 9 points de chance et 8 points d'habilité et son anicenne mue solifiée");
        }
        public static Player Orc()
        {
            return new Player("Orc", 6, 13, 8, new Inventory() { }, false, 10, "ètre sauvage humanoîde\ncommence avec 13 points d'Endurance, 6 points de chance et 8 points d'habilité et peut porter les armes à deux mains avec une");
        }
        public static Player Gnome()
        {
            return new Player("Gnome", 14, 6, 8, new Inventory() {  }, false, 10, "Petit créature magique\nommence avec 8 points d'Endurance, 14 points de chance et 6 points d'habilité");
        }
        public static Player Fee()
        {
            return new Player("Fée", 3, 10, 10, new Inventory() { }, true, 10, "Fée, créature magique \ncommence avec 3 points d'Endurance, 10 points de chance et 10 points d'habilité");
        }
        public static List<Player> GetAllRaces() 
        {
            return new List<Player> { Humain(), Elfe(), Nain(), Saurien(), Orc(), Gnome(), Fee() };
        }
    }
    
}
