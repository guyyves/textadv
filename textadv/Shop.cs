using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textadv
{
    public class Shop
    {
         static int armorMod;
         static int weaponMod;
         static int difMod;

        public static void LoadShop(Player p)
        {
           // armorMod = p.armorVal;
           // weaponMod = p.weaponVal;
           // difMod = p.mods;

            RunShop(p);
        }

        public static void RunShop(Player p)
        {
            int potionP;
            int armorP;
            int weaponP;
            int diffP;

            while (true)
            {
                potionP = 20 + 10 * p.mods;
                armorP = 100 * p.armorVal;
                weaponP = 100 * (p.weaponVal + 1);
                diffP = 300 * p.mods;

                Console.WriteLine("+=======================+");
                Console.WriteLine("|        Shop           |");
                Console.WriteLine("+=======================+");
                Console.WriteLine("|   (p)otion      $"+potionP+"   |");
                Console.WriteLine("|   (a)rmor       $"+armorP +"    |");
                Console.WriteLine("|   (w)eapon      $"+weaponP +"  |");
                Console.WriteLine("|   (d)ifficulty  $"+diffP +"    |");
                Console.WriteLine("+=======================+");

                Console.WriteLine("+=======================+");
                Console.WriteLine("|       "+p.name+"'s Stats        |");
                Console.WriteLine("+=======================+");
                Console.WriteLine("|    Current Health  "+p.health+" |");
                Console.WriteLine("|    Weapon strenght "+p.weaponVal+"  |");
                Console.WriteLine("|    armor strenght  "+p.armorVal+"  |");
                Console.WriteLine("|    potions         "+p.potions+"  |");
                Console.WriteLine("|    Weapon strenght "+p.mods+"  |");
                Console.WriteLine("+=======================+");

                string input = Console.ReadLine().ToLower();
                if(input == "p" || input == "potion")
                {
                    Trybuy("potions", potionP, p);
                }
                if (input == "a" || input == "armor")
                {
                    Trybuy("armor", armorP, p);
                }
                if (input == "w" || input == "weapon")
                {
                    Trybuy("weapon", weaponP, p);
                }
                if (input == "d" || input == "difficulty")
                {
                    Trybuy("diff", diffP, p);
                }
            }
        }
        static void Trybuy(string item, int cost, Player p)
        {
            if(p.coins >= cost)
            {
                if(item == "potion")
                {
                    p.potions++;
                }
                else if(item == "armor")
                {
                    p.armorVal++;
                }
                else if (item == "weapon")
                {
                    p.weaponVal++;
                }
                else if (item == "diff")
                {
                    p.mods++;
                }

                p.coins -= cost;
            }
            else
            {
                Console.WriteLine("je heb niet genoeg coins");
                Console.ReadKey();
            }
        }
    }
}
