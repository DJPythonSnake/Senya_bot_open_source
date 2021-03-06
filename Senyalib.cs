using System;
using System.Diagnostics;
using System.Threading;

namespace Senya
{
    public static class Senyalib
    {
        public static void All_func()
        {
            Console.WriteLine("Выберите одну из функций");
            string[] listfunc = {"пошутить", "открыть проводник", "открыть браузер", "открыть программы", "квадратные уравнения"};
            foreach (string list in listfunc)
            {
                Console.WriteLine(list);
            }
            string choose = Console.ReadLine().ToLower();

            if (choose == listfunc[0])
            {
                Senyalib.Joke();
            }
            else if (choose == listfunc[1])
            {
                Senyalib.Explorer();
            }
            else if (choose == listfunc[2])
            {
                Senyalib.Browser();
            }
            else if (choose == listfunc[3])
            {
                Senyalib.Openprograms();
            }
            else if (choose == listfunc[4])
            {
                Senyalib.Calculatorplus();
            }
        }
        public static void Joke()
        {
            Random rnd = new Random();

            string[] list = {"Что общего между зарплатой и месячными? Оба происходят раз в месяц =)",
                            "Какие числа не использует гей? Натуральные"};

            int rndjoke = rnd.Next(list.Length);
            Console.WriteLine(list[rndjoke]);
            
            Console.WriteLine("Хотите использовать другую функцию или поговорить? Напишите 'поговорить' или 'функция'. Для выхода из программы просто нажмите Enter");
            string an = Console.ReadLine().ToLower();

            if (an == "функция")
            {
                Senyalib.All_func();
            }
            else if (an == "поговорить")
            {
                Program.Says();
            }



        }
        public static void Explorer()
        {
            string x = Console.ReadLine();
            Process.Start(x);
            
            Console.WriteLine("Хотите использовать другую функцию или поговорить? Напишите 'поговорить' или 'функция'. Для выхода из программы просто нажмите Enter");
            string an = Console.ReadLine().ToLower();

            if (an == "функция")
            {
                Senyalib.All_func();
            }
            else if (an == "поговорить")
            {
                Program.Says();
            }
        }
        public static void Browser()
        {
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe");
            
            Console.WriteLine("Хотите использовать другую функцию или поговорить? Напишите 'поговорить' или 'функция'. Для выхода из программы просто нажмите Enter");
            string an = Console.ReadLine().ToLower();

            if (an == "функция")
            {
                Senyalib.All_func();
            }
            else if (an == "поговорить")
            {
                Program.Says();
            }
        }

        public static void Openprograms()
        {
            string[] prog = {"cmd", "ваш редактор кода", "калькулятор"};
            foreach (string i in prog)
            {
                Console.WriteLine(i);
            }

            string[] codes = {"VS Code", "Visual Studio", "Rider"};

            Console.WriteLine("Выберите программу для запуска: ");
            string choose = Console.ReadLine().ToLower();

            if (choose == prog[0])
            {
                Process.Start(@"C:\Windows\System32\cmd.exe");
            }
            else if (choose == prog[1])
            {
                foreach ( string i in codes)
                {
                    Console.WriteLine(i);
                      
                }
                Console.WriteLine("Введите редактор кода");
                string cd = Console.ReadLine();

                if (cd == codes[0])
                {
                    Process.Start(@"C:\Users\artem\AppData\Local\Programs\Microsoft VS Code\Code.exe");
                }

                if (cd == codes[1])
                {
                    Process.Start(@"C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\devenv.exe");
                }

                if (cd == codes[2])
                {
                    Process.Start(@"C:\Program Files\JetBrains\JetBrains Rider 2019.3.1\bin\rider64.exe");
                }
            }
            else if (choose == prog[2])
            {
                Senyalib.Calculator();
            }
            
            
            
            Console.WriteLine("Хотите использовать другую функцию или поговорить? Напишите 'поговорить' или 'функция'. Для выхода из программы просто нажмите Enter");
            string an = Console.ReadLine().ToLower();

            if (an == "функция")
            {
                Senyalib.All_func();
            }
            else if (an == "поговорить")
            {
                Program.Says();
            }



        }

        public static void Calculator()
        {
            Console.WriteLine("Введите 1-е число: ");
            string first = Console.ReadLine();
            int first_num = Convert.ToInt32(first);
            
            Console.WriteLine("Введите 2-е число: ");
            string second = Console.ReadLine();
            int second_num = Convert.ToInt32(second);
            
            Console.WriteLine("Какое действие совершить? ");
            string choose = Console.ReadLine();

            if (choose == "+")
            {
                int result = first_num + second_num;
                string res = Convert.ToString(result);
                Console.WriteLine(res);
            }
            else if (choose == "-")
            {
                int result = first_num - second_num;
                string res = Convert.ToString(result);
                Console.WriteLine(res);
            }
            else if (choose == "*")
            {
                int result = first_num * second_num;
                string res = Convert.ToString(result);
                Console.WriteLine(res);
            }
            else if (choose == "/")
            {
                int result = first_num / second_num;
                string res = Convert.ToString(result);
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("Ошибка!");
            }
            
            Console.WriteLine("Хотите использовать другую функцию или поговорить? Напишите 'поговорить' или 'функция'. Для выхода из программы просто нажмите Enter");
            string an = Console.ReadLine().ToLower();

            if (an == "функция")
            {
                Senyalib.All_func();
            }
            else if (an == "поговорить")
            {
                Program.Says();
            }
        }

        public static void Calculatorplus()
        {
            Console.WriteLine("Решение уравнения вида ax^2 + bx + c = 0");
            Thread.Sleep(40000);
            Console.Write("Введите значение a: ");
            string first = Console.ReadLine();
            float a = Convert.ToInt32(first);
            
            Console.Write("Введите значение b: ");
            string second = Console.ReadLine();
            float b = Convert.ToInt32(second);
            
            Console.Write("Введите значение c: ");
            string third = Console.ReadLine();
            float c = Convert.ToInt32(third);
            
            Console.WriteLine("D = b^2 + 4ac");
            double square_b = Math.Pow(b, 2);
            int discriminant = Convert.ToInt32(square_b + 4 * a * c);
            Console.WriteLine(discriminant);

            if (discriminant < 0)
            {
                Console.WriteLine("Решений нет!");
            }
            
            else if (Convert.ToBoolean(discriminant = 0))
            {
                Console.WriteLine("Уравнение имеет 1 корень");
                int square = Convert.ToInt32(square_b / 2 * a);
                Console.WriteLine("x1 =", square);
            }
            
            else if (discriminant > 0)
            {
                Console.WriteLine("Уравнение имеет 2 корня");

                double discr_sqrt = Math.Sqrt(discriminant);
                int x1 = Convert.ToInt32((-b + discr_sqrt) / 2 * a);
                int x2 = Convert.ToInt32((-b - discr_sqrt) / 2 * a);
                Console.WriteLine("x1 = ", x1);
                Console.WriteLine("x2 = ", x2);
            }
            
            Console.WriteLine("Хотите использовать другую функцию или поговорить? Напишите 'поговорить' или 'функция'. Для выхода из программы просто нажмите Enter");
            string an = Console.ReadLine().ToLower();

            if (an == "функция")
            {
                Senyalib.All_func();
            }
            else if (an == "поговорить")
            {
                Program.Says();
            }
        }

    }
}