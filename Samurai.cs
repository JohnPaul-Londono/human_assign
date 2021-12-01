using System;

namespace human_assign
{
    public class Samurai: Human
    {
        public Samurai(string n): base(n, 3, 3, 3, 200)
        {
            Name = n;
        }
        public override int Attack(Human target)
        {
            base.Attack(target);
            if(target.Health < 50)
            {
                target.Health = 0;
            }
            return target.Health;
        }

        public int Meditate(Human target)
        {
            Health = 200;
            return Health;
        }

    }
}