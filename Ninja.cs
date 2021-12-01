using System;

namespace human_assign
{
    public class Ninja: Human
    {
        public Ninja(string name): base(name, 3, 3, 175, 100)
        {
            Name = name;
        }

        public override int Attack(Human target)
        {
            int newHealth = target.Health;
            newHealth -= 5 * Dexterity;
            target.Health=newHealth;
            Random rand = new Random();
            int moreDamage = rand.Next(5);
            if(moreDamage == 0)
            {
                target.changeHealth(-10);
            }
            return newHealth;
        }

        public int Steal(Human target)
        {
            target.changeHealth(-5);
            changeHealth(5);
            return Health;
        }

        // public override int extraDamage(Human target){
        //     int newHealth = target.getHealth;
        //     Random rand = new Random();
        //     int moreDamage = rand.Next (5);
        //     if(moreDamage == 0)
        //     {
        //         target.setHealth(newHealth);
        //     }
        //     return newHealth;
        }

}
