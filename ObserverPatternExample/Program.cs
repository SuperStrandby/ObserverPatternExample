using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Brian = new Student("Brian");

            Teacher Ebbe = new Teacher("Ebbe");

            Ebbe.AddObserver(Brian);
            Ebbe.GiveOrder("Take a day off!");

            Console.ReadLine();
            Console.WriteLine();

            Student Per = new Student("Per");
            Ebbe.AddObserver(Per);
            Ebbe.GiveOrder("Fyr op for musikken!");

            Console.ReadLine();
            Console.WriteLine();

            Ebbe.RemoveObserver(Per);
            Console.ReadLine();

        }
    }
}
