using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace format
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person { Name = "Tom", Age = 23 };

            Console.WriteLine($"Имя: {person.Name}  Возраст: {person.Age}");
            Console.ReadLine();
        }

        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    
    }
}
