using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_Gorshkov_Sergey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Это простейшая программа 'Анкета'. Давайте знакомиться. ");
            
            Console.WriteLine("Как я могу к Вам обращаться?");
            String name = Console.ReadLine();
            if (name == "")
            {
                name = "User";
            }
            Console.WriteLine("Здравствуйте, " + name + "!");

            Console.WriteLine(name + ". Какая у Вас фамилия?");
            String subName = Console.ReadLine();
            
            Console.WriteLine(name + ". Сколько Вам лет?");
            String age = Console.ReadLine();
            
            Console.WriteLine(name + ". Какой у Вас рост?");
            String growth = Console.ReadLine();
           
            Console.WriteLine(name + ". Какой у Вас вес?");
            String weight = Console.ReadLine();
           
            Console.WriteLine(name + ". Спасибо за Ваше участие! Вот что у нас получилось: \n" + subName + " " + name + " в возрасте " + age + " лет вымахал до " + growth + " см, а весит " + weight + " кг. ");
            String genre = Console.ReadLine();





            double x;
            double y;

            Console.WriteLine("{0:c1}", 12345);
            Console.Write("Введите первое число: ");
            string str = Console.ReadLine();
            x = Convert.ToDouble(str);
            Console.Write("Введите второе число: ");
            y = Convert.ToDouble(Console.ReadLine());
            double z = x + y;
            Console.WriteLine(x + " + " + y + " = " + z);     // Преобразование в строку
            Console.WriteLine("{0:c3}", z + x + "=");
            Console.WriteLine("{0:C1}", z);
            Console.ReadLine();
        }
    }
}
