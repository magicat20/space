using System;

namespace questionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Автор: Валерия Пинигина

            // Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).
            // В результате вся информация выводится в одну строчку:
            // а) используя склеивание;
            // б) используя форматированный вывод;
            // в) используя вывод со знаком $.

            Console.WriteLine("Какое у Вас имя?");
            string name = Console.ReadLine();

            Console.WriteLine("Какая у Вас фамилия?");
            string fname = Console.ReadLine();

            Console.WriteLine("Сколько Вам лет?");
            byte age = Convert.ToByte(Console.ReadLine());

            Console.WriteLine(name + " " + fname + "," + age.ToString() + "лет") ;
            Console.WriteLine("{0}, {1} лет", name, age);
            Console.WriteLine($"{fname}, {age} лет");


            // Автор: Пинигина Валерия
            // 1. Ввести вес и рост человека.
            // 2. Рассчитать и вывести индекс массы тела(ИМТ). 
            // Использовать для этого формулу I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.
            
            double m;
            double h;

            Console.WriteLine("Cколько Вы весите в килограммах?");
            string str = Console.ReadLine();
            m = Convert.ToDouble(str);
            Console.WriteLine("Какой у вас рост? Пожалуйста, введите в метрах");
            h = Convert.ToDouble(Console.ReadLine());

            double x = m / h * h;
            Console.WriteLine("Ваш индекс массы тела составляет:" + x);


            // Автор: Пинигина Валерия
            // Задание 5.
            // Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.

            Console.WriteLine("Пожалуйста, еще раз введите свое имя");
            string a = Console.ReadLine();

            Console.WriteLine("А также фамилию");
            string b = Console.ReadLine();

            Console.WriteLine("А в каком городе Вы проживаете?");
            string c = Console.ReadLine();

            Console.WriteLine(a + " " + b + "," + "город" + c);

            Console.ReadKey();



            
        }
    }
}
