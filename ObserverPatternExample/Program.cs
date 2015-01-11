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

            Student John = new Student("John");
            Ebbe.AddObserver(John);
            Ebbe.GiveOrder("Fyr op for musikken!");

            Console.ReadLine();
            Console.WriteLine();

            Ebbe.RemoveObserver(John);
            Console.ReadLine();

        }
    }
}
