using System;

namespace DungeonStats
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int request1 = int.Parse(args[0]);
            int request2 = int.Parse(args[1]);
            
            Console.WriteLine(Damage(request1, request2));
            Console.WriteLine(Damage(request1));
            Console.WriteLine(CriticalHit(request1));
        }

        private static int Damage (int attack, int defense)
        {
            int damage = attack - defense;
            return damage;
        }

        private static int Damage (int attack)
        {
            int damage = attack;
            return damage;
        }

        private static int CriticalHit (int damage)
        {
            int crit;
            if (damage == 1)
                crit = 1;
            else
                crit = damage + CriticalHit(damage + (damage - 1));
            return crit;
            
        }
    }
}
