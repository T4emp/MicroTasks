using System;

namespace MicroTasks
{
    class Program
    {
        public string s1, s2;
        public int i1, i2;
        public float f1;

        static void Main()
        {
            var needToContinue = true;
            while (needToContinue)
            {
                Menu();
                Console.WriteLine("Начать заново? (Ent)");
                var key = Console.ReadKey().Key;
                do
                {
                    if (key == ConsoleKey.Escape)
                    {
                        needToContinue = false;
                    }
                    else if (key != ConsoleKey.Enter)
                    {
                        Console.WriteLine("Неправильная клавиша! Начать заного? (Ent)");
                        key = Console.ReadKey().Key;
                    }
                }
                while (needToContinue && key != ConsoleKey.Enter);
                Console.Clear();
            }
        }

        public static void Menu()
        {
            Program program = new Program();
            Console.WriteLine("Номер задачи: ");
            program.s1 = Console.ReadLine();
            program.i1 = Convert.ToInt32(program.s1);
            switch (program.i1)
            {
                case 1:
                    First();
                    break;
                case 2:
                    Second();
                    break;
                case 3:
                    Third();
                    break;
                case 4:
                    FAndF(false);
                    break;
                case 5:
                    FAndF(true);
                    break;
            }
        }

        public static void First()
        {
            Program program = new Program();
            Console.WriteLine("Первое число: ");
            program.s1 = Console.ReadLine();
            program.i1 = Convert.ToInt32(program.s1);
            Console.WriteLine("Второе число: ");
            program.s2 = Console.ReadLine();
            program.i2 = Convert.ToInt32(program.s2);
            if (program.i1 > program.i2)
            {
                Console.WriteLine($"Число {program.i1} больше числа {program.i2}");
            }
            else if (program.i1 < program.i2)
            {
                Console.WriteLine($"Число {program.i1} меньше числа {program.i2}");
            }
            else
            {
                Console.WriteLine($"Число {program.i1} равно числу {program.i2}");
            }
        }

        public static void Second()
        {
            Program program = new Program();
            Console.WriteLine("Число: ");
            program.s1 = Console.ReadLine();
            program.i1 = Convert.ToInt32(program.s1);
            if (program.i1 > 5 & program.i1 < 10)
            {
                Console.WriteLine($"Число больше 5 и меньше 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
        }

        public static void Third()
        {
            Program program = new Program();
            Console.WriteLine("Число: ");
            program.s1 = Console.ReadLine();
            program.i1 = Convert.ToInt32(program.s1);
            if (program.i1 == 5 ^ program.i1 == 10)
            {
                Console.WriteLine($"Число либо равно 5, либо равно 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
        }

        public static void FAndF(bool b1)
        {
            Program program = new Program();
            float f1 = program.f1;
            Console.WriteLine("Сумма вклада: ");
            program.s1 = Console.ReadLine();
            program.i1 = Convert.ToInt32(program.s1);
            if (program.i1 <= 100)
            {
                f1 = (float)(program.i1 + (program.i1 * 0.07));
            }
            else if (program.i1 > 100 & program.i1 < 200)
            {
                f1 = (float)(program.i1 + (program.i1 * 0.09));
            }
            else if (program.i1 >= 200)
            {
                f1 = (float)(program.i1 + (program.i1 * 0.12));
            }
            Console.WriteLine($"Сумма вклада с начислениями: {f1}");
            if (b1 == true)
            {
                Console.WriteLine($"Сумма вклада с начислениями + бонусами: {f1 + 15}");
            }
        }
    }
}