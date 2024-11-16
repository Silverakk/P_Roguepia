﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using P_Roguepia.Properties;

namespace P_RogueTower.Data
{
    static class DataMonsters
    {
        public static Monstre GetImp()
        {
            return new Monstre(
            "Diablotin",
            2,
            Dice.Lancer(3) + 3,
            Dice.Lancer(3) + 3,
            false,
            Dice.Lancer(3),
            new Inventory { DataItems.Rubis() }
            );
        }

        public static Monstre GetBicephalRaven()
        {
            return new Monstre(
            "Corbeau Bicephale",
            2,
            Dice.Lancer(4) + 2,
            Dice.Lancer(2) + 6,
            false,
            Dice.Lancer(2),
            null,
            Resources.CorbeauBicephale
            );
        }
        public static Monstre GetTestBoss()
        {
            return new Monstre(
            "Test Boss",
            2,
            Dice.Lancer(5) + 2,
            Dice.Lancer(2) + 6,
            true,
            Dice.Lancer(2),
            null,
            null,
            false
            );
        }


        public static List<Monstre> GetAllMonsters()
        {
            return new List<Monstre> { GetImp(), GetBicephalRaven() };
        }
        public static List<Monstre> GetFirstFloorMonsters()
        {
            return new List<Monstre> { GetImp(), GetBicephalRaven() };
        }
        public static List<Monstre> GetFirstTestBoss()
        {
            return new List<Monstre> { GetTestBoss() };
        }
    }
}