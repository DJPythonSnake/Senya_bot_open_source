using System;
using System.Diagnostics;


namespace Senya
{
    public static class Senyalib
    {
        public static void All_func()
        {
            Console.WriteLine("Выберите одну из функций");
            string[] listfunc = {"пошутить", "открыть проводник", "открыть браузер", "открыть программы"};
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
            string[] prog = {"cmd", "ваш редактор кода"};
            foreach (string i in prog)
            {
                Console.WriteLine(i);
            }

            string[] codes = {"VS Code", "Visual Studio", "Rider"};

            Console.WriteLine("Выберите программу для запуска: ");
            string choose = Console.ReadLine();

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