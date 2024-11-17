using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_RogueTower.Data
{
    static class DataItems
    {
        
        public static Item Rubis()
        {
            return new Item("Rubis", 5, "Pierre précieuse brute");
        }
        public static Item Jade()
        {
            return  new Item("Jade", 6, "Pierre précieuse polie");
        }
        public static Item Opal()
        {
            return new Item("Opal", 7, "Pierre précieuse taillée");
        }
        public static Item PoudreMagique()
        {
            return new PoudreMagique();
        }
        public static Item PotiondeFortune()
        {
            return new PotiondeFortune();
        }
        public static Item ElixirdeVitalite()
        {
            return new ElixirdeVitalite();
        }
        public static Item NectarDeRegeneration()
        {
            return new NectarDeRegeneration();
        }

        public static Item Torche()
        {
            return new Torche();
        }
        public static Item Ration()
        {
            return new Ration();
        }
        public static Item Bombe()
        {
            return new Bombe();
        }
        public static Item GrisGris()
        {
            return new GrisGris();
        }
        public static Item CouteauDeLance()
        {
            return new CouteauDeLancer();
        }
        public static Item EauBenite()
        {
            return new EauBenite();
        }



        public static List<Item> GetAllItem()
        {
            return new List<Item> {  };
        }
        public static List<Item> GetStartingItem()
        {
            return new List<Item> { PotiondeFortune(), ElixirdeVitalite(), NectarDeRegeneration(), Opal(), GrisGris(), Bombe(), CouteauDeLance(),DataEquipement.Dagger(), DataEquipement.Bouclier(), DataEquipement.Grimoire() };
        }
        public static List<Item> GetShopItem()
        {
            return new List<Item> { PotiondeFortune(), ElixirdeVitalite(), NectarDeRegeneration(), Opal(), GrisGris(), Bombe(), EauBenite() ,CouteauDeLance(), DataEquipement.Dagger(), DataEquipement.Bouclier(), DataEquipement.Grimoire() };
        }

    }
    [Serializable]
    internal class PoudreMagique : Consummable
    {
        public PoudreMagique() : base("Poudre Magique", 10,"Donne au personnage un lien magique pendant 3 pièces",1,true,3)
        {

        }
        public override void Consume(Game game)
        {
            game.Player.IsMagic = true;
        }
        public override void EndOfTimeCounter(Game game)
        {
            game.Player.IsMagic = false;
        }
    }
    [Serializable]
    internal class PotiondeFortune : Consummable
    {
        public PotiondeFortune() : base("Potion de Foturne", 20)
        {

        }
        public override void Consume(Game game)
        {
            game.Player.BaseChance++;
            game.Player.Chance = game.Player.BaseChance;
        }
    }
    [Serializable]
    internal class ElixirdeVitalite  : Consummable
    {
        public ElixirdeVitalite() : base("Élixir de Vitalité", 20)
        {
     
        }
        public override void Consume(Game game)
        {
            game.Player.Endurance = game.Player.BaseEndurance;
        }
    }
    [Serializable]
    internal class NectarDeRegeneration : Consummable
    {
        public NectarDeRegeneration() : base("Nectar de Régénération", 20, "Rend Habilité")
        {
 
        }
        public override void Consume(Game game)
        {
            game.Player.Habilite = game.Player.BaseHabilite;
        }
    }
    [Serializable]
    internal class Torche : Consummable
    {
        public Torche() : base("Torche", 4, "Un bâton entouré de tissu et graisse, permet de voir dans le noir sur 5 salles",1,true,5)
        {

        }
        public override void Consume(Game game)
        {
            game.Player.IsLighted = true;
        }
        public override void EndOfTimeCounter(Game game)
        {
            game.Player.IsLighted = false;
        }
    }
    [Serializable]
    internal class Ration : Consummable
    {
        public Ration() : base("Ration", 4, "Provision de voyage commun utilié par les voyageurs, marchands et aventuriers.\nRend 3 points d'Endurance")
        {

        }
        public override void Consume(Game game)
        {
            game.Player.Endurance += 3;
        }
    }
    [Serializable]

    internal class GrisGris : Consummable
    {
        public GrisGris() : base("Gris-Gris", 7, "Vistemboir vennant d'une contrée lointaine, porte bonheur pour certains, signe de mauvais présage pour d'autre. Rend 3 Endurance et 3 Chance mais assombri la salle.")
        {

        }
        public override void Consume(Game game)
        {
            game.Player.Chance += 3;
            game.Player.Endurance += 3;
            game.GetRoom().Light = false;
        }
    }
    [Serializable]
    internal class Bombe : Consummable
    {
        public Bombe() : base("Bombe", 7, "à 50% d'exploser sur l'ennemi\nInflige 5 dégâts")
        {

        }
        public override void Consume(Game game)
        {
            Lieu room = game.GetRoom();

            if(room.MonsterPool != null)
            {
                if(Dice.Lancer(2) == 1) 
                {
                    game.GetMonster().Endurance -= 5;
                } 
                
            }
        }
    }
    [Serializable]
    internal class EauBenite : Consummable
    {
        public EauBenite() : base("Eau Bénite", 10, "Inflige 4 dégâts à une créature magique")
        {

        }
        public override void Consume(Game game)
        {
            Lieu room = game.GetRoom();

            if (room.MonsterPool != null)
            {
                if (game.GetMonster().IsMagic)
                {
                    game.GetMonster().Endurance -= 4;
                }

            }
        }
    }
    [Serializable]
    internal class CouteauDeLancer : Consummable
    {
        public CouteauDeLancer() : base("Couteau de lancer", 3, $"Inflige 1 dégât, 2 utilisations",2)
        {
            
        }
        public override void Consume(Game game)
        {
            this.Description = $"Inflige 1 dégât, 1 utilisation";

            if (game.GetRoom().MonsterPool != null)
            {
                game.GetMonster().Endurance -= 1;
            }
        }
    }
}
