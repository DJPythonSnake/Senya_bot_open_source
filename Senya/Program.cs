﻿using System;

namespace Senya
{
    class Program
    {
        public static void Says()
        {
            Random rndsay = new Random();
            string[] says = {"программирование", "как дела?", "музыка"};
			foreach (string list in says)
            {
                Console.WriteLine(list);
            }

            string[] prog = {"Программирование словно ремесло. Я, кстати, написан на С#", "Программирование - это очень круто, но также сложно."};
            int rndprog = rndsay.Next(prog.Length);
            string[] howareyou = {"Неплохо", "Хорошо", "Отлично!", "Ужасно!"};
            int rndhowareyou = rndsay.Next(howareyou.Length);
            string[] music = {"Музыка - удивительная вещь! Какая же разная она бывает", "Я люблю слушать музыку! Даже не смотря на то, что я бот."};
            int rndmusic = rndsay.Next(music.Length);
            
            Console.WriteLine("Что обсудим?");
            string choose = Console.ReadLine().ToLower();

            if (choose == says[0])
            {
                Console.WriteLine(prog[rndprog]);
            }
            else if (choose == says[1])
            {
                Console.WriteLine(howareyou[rndhowareyou]);
            }
            else if (choose == says[2])
            {
                Console.WriteLine(music[rndmusic]);
            }

            bool talk = true;
            while (talk)
            {
                Console.WriteLine("Хотите продолжить диалог? Напишите 'да' или 'нет'. Если хотите использовать функцию - напишите 'функция'. Для выхода из программы просто нажмите Enter");
                string answer = Console.ReadLine().ToLower();

                if (answer == "да")
                {
                    Program.Says();
                }
                else if (answer == "нет")
                {
                    Console.WriteLine("Пока");

                }
                else if (answer == "функция")
                {
                    Senyalib.All_func();
                }
                break;

            }

        }
        public static void Saing()
        {
            Console.WriteLine("Привет! Я Сеня! Как тебя зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Привет, " + name);
            Console.WriteLine("Хотите поболтать или использовать одну из функций? Напишите 'поболтать' или 'функция'. Для выхода из программы просто нажмите Enter");
            string ch = Console.ReadLine().ToLower();


            if (ch == "поболтать")
            {
                Program.Says();
            }
            else if (ch == "функция")
            {
                Senyalib.All_func();
            }
        }

        public static void Main(string[] args)
        {
            Program.Saing();


        }
    }
}
