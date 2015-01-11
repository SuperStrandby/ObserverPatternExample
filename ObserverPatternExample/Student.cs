using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternExample
{
    public class Student : INotify
    {
        private readonly string _name;

        public Student(string name)
        {
            _name = name;
        }
        public void Notify()
        {
            Console.WriteLine("Order given to {0}: {1}", _name, Teacher.Order);
        }
    }
}
