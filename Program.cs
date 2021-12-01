using System;

namespace human_assign
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Ken = new Human("Ken");
            Wizard Wiz = new Wizard("Wiz");
            Ninja Nin = new Ninja("Nin");
            Samurai Sam = new Samurai("Sam");

            Wiz.Attack(Nin);
            Console.WriteLine(Nin.Health);
            Console.WriteLine(Wiz.Health);

            Nin.Attack(Sam);
            Console.WriteLine(Sam.Health);

            Wiz.Heal(Ken);
            Console.WriteLine(Ken.Health);

            Sam.Meditate(Sam);
            Console.WriteLine(Sam.Health);

            Nin.Steal(Ken);
            Console.WriteLine(Ken.Health);
            Console.WriteLine(Nin.Health);

            
        }
    }
}
