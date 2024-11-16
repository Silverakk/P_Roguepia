using P_RogueTower.LivingCreatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_RogueTower.Data
{
    static class DataEtages
    {

        public static Etage EtageTest()
        {
            DataLieuxChildren dataLieuxChildren = new DataLieuxChildren();
            return new Etage("simple étage", "l'étage d'un donjon tout ce qu'il y a de plus administratif", dataLieuxChildren.SimpleEtage());
        }
        public static Etage EtageVide()
        {
            return new Etage(" ", " ", DataLieux.SommetDuDonjonTest());
        }

        public static List<Etage> TestDunjon() 
        {
            return new List<Etage> 
            {
                
                EtageTest(),
                EtageVide()
            };
        }
        public static List<Etage> Vide()
        {
            return new List<Etage>
            {
                EtageVide()
            };
        }

    }

}
