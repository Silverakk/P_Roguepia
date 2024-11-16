using P_RogueTower.LivingCreatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;

namespace P_RogueTower
{

    static class DataEquipement
    {
        public static Arme Sword()
        {
            return new Arme(2, 2, 0, "Épée", 10, $"Ancienne épée\nInflige 2 dégâts\nMalus d'habilite de 0 en combat");
        }
        public static Arme Dagger()
        {
            return new Arme(1, 1, 0, "Dague", 5, "Petit dague à une main\nInflige 1 dégâts\nMalus d'habilite de 0 en combat");
        }
        public static Arme Lance()
        {
            return new Arme(2, 1, -1, "Lance", 10, "Longue lance en acier trempé\nInflige 1 dégâts\nBonus d'habilite de 1 en combat");
        }
        public static Arme Axe()
        {
            return new Arme(2, 3, 1, "Hache", 10, "Hache de guerre vennant d'un cimetière\nInflige 3 dégâts\nMalus d'habilite de 1 en combat");
        }
        public static Arme Morgenstern()
        {
            return new Arme(1, 2, 1, "Étoile du matin", 10, "arme à une main couvert de pointe\nInflige 2 dégâts\nMalus d'habilite de 1 en combat");
        }
        public static Arme Zweihander()
        {
            return new Arme(2, 4, 2, "Zweihander", 10, "Longue épée à deux mains\nInflige 4 dégâts\nMalus d'habilite de 2 en combat");
        }
        public static Arme BrasDroit()
        {
            return new Arme(1, 0, 0, "Bras droit", 0,"votre bras droit");
        }
        public static Arme Poignard()
        {
            return new Poignard();
        }

        public static Arme NeoSword = new Arme(2, 3, 0, "Néo-Katana", 30, "Une arme légendaire ");
        public static Arme LanceDeLonginus = new Arme(2, 2, 1, "Lance de Longinus", 30, "Une arme mystique ");

        public static Equipement Bouclier()
        {
            return new Bouclier();
        }
        public static Equipement MueSolidifee()
        {
            return new MueSolidifee();
        }
        
        public static Equipement BrasGauche()
        {
            return new BrasGauche();
        }

        public static List<Equipement> GetAllItem()
        {
            return new List<Equipement> { };
        }
        public static List<Equipement> GetStartingWeapons()
        {
            return new List<Equipement> { Sword(), Lance(), Axe(), Dagger(), Zweihander(), Morgenstern(), Poignard() };
        }

    }
    [Serializable]
    internal class Bouclier : ArmureBrasGauche
    {
        public Bouclier() : base("Bouclier",10, "Un simple bouclier, 1 une chance sur 6 de déflecter un dégât reçu")
        {
          
        }
        
        
        public override void Block(Game game)
        {
            if(Dice.Lancer() % 6 == 0)
            {
                game.Player.Endurance++;
            }
        }

    }
    [Serializable]
    internal class MueSolidifee : ArmureBrasGauche
    {
        public MueSolidifee() : base("Mue solidifée", 10, "votre mue solidifée et durcie vous servant d'armure\nune chance sur 6 de déflecter 2 dégâts")
        {

        }


        public override void Block(Game game)
        {
            if (Dice.Lancer() % 6 == 0)
            {
                if(game.GetMonster().Puissance > 1)
                {
                    game.Player.Endurance += 2;
                }
                else if(game.GetMonster().Puissance == 1)
                {
                    game.Player.Endurance += 1;
                }
                
            }
        }
    }

    [Serializable]
    internal class Prise : ArmureBrasGauche
    {
        public Prise() : base("Prise", 0)
        {

        }

    }
    [Serializable]
    internal class Vide : ArmureBrasGauche
    {
        public Vide() : base("Vide", 0)
        {

        }

    }
    [Serializable]
    internal class BrasGauche : ArmureBrasGauche
    {
        public BrasGauche() : base("Bras gauche", 0, "Votre bras gauche")
        {

        }

    }
    [Serializable]
    internal class Poignard : Arme
    {
        public Poignard() : base(1,1,0, "Poignard",10,"Inflige 1 dégât supplémentaire si le personnage est chanceux\nInflige 1 dégâts\nMalus d'habilite de 0 en combat")
        {

        }
        public override void LuckBasedMove(Game game)
        {
            game.GetMonster().Endurance =- 1;
        }
    }

}
