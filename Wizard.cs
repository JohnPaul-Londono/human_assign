using System;


namespace human_assign
{
    public class Wizard: Human
    {
        public Wizard(string name): base(name, 3, 25, 3, 50)
        {
            // Name = name;
        }

        public override int Attack(Human target)
        {
            int newHealth = target.Health;
            newHealth -= 5 * Intelligence;
            target.Health=newHealth;
            int healing = Health;
            healing += 5 * Intelligence;
            Health=healing;
            return newHealth;
            
        }

        // public int HealWiz(Human target)
        // {

        // }

        public int Heal(Human target)
        {
            int newHealth = target.Health;
            newHealth += 10 * Intelligence;
            target.Health=newHealth;
            return newHealth;
        }
    }
} 