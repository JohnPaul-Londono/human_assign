using System;

namespace human_assign
{

    public class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        protected int health;

        // add a public "getter" property to access health
        public int Health
        {
            get {return health;}
            set{health = value;}
            
        }
        // public void setHealth (int health)
        // {
            
        // }

        public void changeHealth(int change)
        {
            Health += change;
        }
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human( string n )
        {
            Name = n;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;

        }

        // Add a constructor to assign custom values to all fields
        public Human(string n, int str, int itl, int dex, int hth)
        {
            Name = n;
            Strength = str;
            Intelligence = itl;
            Dexterity = dex;
            Health = hth;
        }

        // Build Attack method
        public virtual int Attack(Human target)
        {
            target.Health -= 5 * Strength;
            return target.Health;
        }
        public virtual int extraDamage(Human target)
        {
            target.Health -= 10;
            return Health; 
        }

        

    }
}