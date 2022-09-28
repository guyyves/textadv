using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textadv
{
    class Battle
    {
        static Random rand = new Random();
        // BattleDefault

        // Battles
        public static void FirstBattle()
        {
            Console.WriteLine("Test battle met wapen");
            Console.WriteLine("Lorem");
            Console.ReadKey();
            Battles(false, "Bruine Beer", 1, 4);
        }
        public static void BasicBattle()
        {
            Console.Clear();
            Console.WriteLine("lorem");
            Console.ReadKey();
            Battles(true, "--", 0, 0);
        }
        public static void GurgBattle()
        {
            Console.Clear();
            Console.WriteLine("Lorem");
            Console.ReadKey();
            Battles(false,"Gurg de Huidloper", 5, 2);
        }
        // BattleTools

        public static void randomBattle()
        {
            switch(rand.Next(0,2))
            {
                case 0:
                    BasicBattle();
                    break;
                case 1:
                    GurgBattle();
                    break;
            }
             
        }
        public static void Battles(bool random,string name , int power, int health)
        {
            string n = "";
            int p = 0;
            int h = 0;
            if(random)
            {
                n = GetName();
                p = rand.Next(1,5);
                h = rand.Next(1, 8);
            }
            else
            {
                n = name;
                p = power;
                h = health;

            }
            while(h > 0)
            {
                Console.Clear();
                Console.WriteLine(n);
                Console.WriteLine(p+ "/" +h);
                Console.WriteLine("====================");
                Console.WriteLine("| (a)ttack (d)efend |");
                Console.WriteLine("| (r)un    (h)ealth |");
                Console.WriteLine("====================");
                Console.WriteLine(" Potions: "+Program.player.potions+" Health: "+Program.player.health);
                string input = Console.ReadLine();
                if(input.ToLower() == "a" || input.ToLower() == "attack")
                {
                    //Attack
                    Console.WriteLine("je valt " + n+ " aan");
                    int damage = p - Program.player.armorVal;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Program.player.weaponVal) + rand.Next(1,4);
                    
                    Console.WriteLine("je verliest "+ damage + " Health en je doet "+ attack + " damage");
                    Program.player.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    //Defend
                    int damage = (p/4) - Program.player.armorVal;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Program.player.weaponVal)/2;
                    Console.WriteLine(n+"probeerd je aantevallen");
                    Console.WriteLine("je verliest " + damage + " Health en je doet " + attack + " damage");
                    Program.player.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                    //Run
                    if (rand.Next(0, 2) == 0) 
                    {
                        Console.WriteLine("Het is niet gelukt om weg te rennen van "+n);
                        int damage = p -= Program.player.armorVal;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("je verliest "+damage+" health");
                        Console.ReadKey();
                        //ga naar de store
                    }
                    else
                    {
                        Console.WriteLine("Het is je gelukt om te ontsnappen van "+n);
                    }
                }
                else if (input.ToLower() == "h" || input.ToLower() == "heal")
                {
                    //Heal
                    if(Program.player.potions == 0)
                    {
                        Console.WriteLine("je heb geen potions meer");
                        int damage = p -= Program.player.armorVal;
                        if (damage < 0)
                            damage = 0;
                        Program.player.health -= damage;
                        Console.WriteLine("The "+n+ "valt je aan en je verliest "+damage+" aan healt");
                    }
                    else
                    {
                        Console.WriteLine("je gebruikt een potion");
                        int healingV = 5;
                        Console.WriteLine("je Healt "+ healingV + " health");
                        Program.player.health += healingV;
                        Console.WriteLine("terwhijl je een potion drink valt " + n + " je aan");
                        int damage = (p / 2) - Program.player.armorVal;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("Je verliest "+damage+ " Health");
                        Program.player.potions -= 1;

                    }
                }
                if(Program.player.health <= 0)
                {
                    //death
                    Console.Clear();
                    Console.WriteLine(@"                                 )                    ");
                    Console.WriteLine(@" (                            ( /(                    ");
                    Console.WriteLine(@" )\ )       )     )      (    )\())   )      (   (    ");
                    Console.WriteLine(@"(()/(    ( /(    (      ))\  ((_)\   /((    ))\  )(   ");
                    Console.WriteLine(@" /(_))_  )(_))   )\  ' /((_)   ((_) (_))\  /((_)(()\  ");
                    Console.WriteLine(@"(_)) __|((_)_  _((_)) (_))    / _ \ _)((_)(_))   ((_) ");
                    Console.WriteLine(@"  | (_ |/ _` || '  \()/ -_)  | (_) |\ V / / -_) | '_| ");
                    Console.WriteLine(@"   \___|\__,_||_|_|_| \___|   \___/  \_/  \___| |_|   ");
                    Console.WriteLine("Je bent dood gemaakt door " + n);
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
                Console.ReadKey();
            }
            int c = rand.Next(10, 50);
            Console.WriteLine("Je hebt de "+n+" verslagen je hebt "+c+" coins gekregen");
            Program.player.coins += c;
            Console.ReadKey();
        }
        
         
        public static string GetName()
        {
            switch(rand.Next(0,6))
            {
                case 0:
                    return "Wolf";
                    
                case 1:
                    return "Een OntWaakt Lijk";
                    
                case 2:
                    return "Vampier";
                    
                case 3:
                    return "gurg";
                    
                case 4:
                    return "Huid Loper";
                    
                case 5:
                    return "BruhMan";
                    
                case 6:
                    return "DunnerMan";
                    
                case 7:
                    return "Slechte Dragon";
                    
                case 8:
                    return "Andre Slang";
                    
                case 9:
                    return "Een Paarse Dino";
                    
                case 10:
                    return "Bruh";
                    
            }
            return "Mens";
        }
    }
}
