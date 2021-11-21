using System;
using System.Threading;

namespace textGameStory.chapters
{
    public class CThree
    {
        public static void C3(ref string name, ref string sex, ref int hp, ref int[] characteristics)
        {
            ChapterStart.ChapStart(3);

            #region Gender 
            string sexFor0;
            string sexFor1;
            string sexFor3;
            string sexFor4;
            string sexFor5;
            string sexFor6;

            if (sex == "man")
                sexFor0 = "Дорогой";
            else
                sexFor0 = "Дорогая";

            if (sex == "man")
                sexFor1 = "большой";
            else
                sexFor1 = "большая";

            if (sex == "man")
                sexFor3 = "умный";
            else
                sexFor3 = "умная";

            if (sex == "man")
                sexFor4 = "вырос";
            else
                sexFor4 = "выросла";

            if (sex == "man")
                sexFor5 = "разобрался";
            else
                sexFor5 = "разобралась";

            if (sex == "man")
                sexFor6 = "внуком";
            else
                sexFor6 = "внучкой";
            #endregion

            string[] dialog = new string[4];
            dialog[0] = $"{sexFor0}, {name}. Сегодня тебе исполняется целых 3 годика.";
            dialog[1] = $"Ты уже совсем {sexFor1}. Мы с папой подготовили тебе подарок.";

            dialog[2] = "Мама достает из-за спины крассивую коробку завернутую в оберточную бумагу и перевязанную праздничной лентой";

            if (MainCharacter.characteristics[0] == 1)
            {

                dialog[3] = $"Ты у нас очень {sexFor3}. Поэтому мы решили подарить тебе эту логическую игру.";
            }
            else
            {
                dialog[3] = $"Мы тебя очень любим и хотим чтобы ты {sexFor4} без недостатков. Поэтому мы решили подарить тебе эту логическую игру.";
            }

            for (int i = 0; i < dialog.Length; i++)
            {
                if (i == 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(dialog[i]);
                    Console.WriteLine("");
                    Console.ResetColor();
                    Thread.Sleep(3000);
                }
                else
                {
                    Console.WriteLine(dialog[i]);
                    Console.WriteLine("");
                    Thread.Sleep(3000);
                }
            }

            if (MainCharacter.characteristics[0] == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\n1. Принять подарок и идти играть в свою комноту \n2. Принять подарок и рассказать стихотворение в знак блогодарности \n");
                Console.ResetColor();

                string input1 = Console.ReadLine();
                string input = Console.ReadLine();
                string rezChoise1 = InputParse.ResInputParse(input, 2);

                if (rezChoise1 == "1")
                {
                    characteristics[0] += 2;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"Ты быстро {sexFor5} игрой и она даже успела тебе наскучить. Остаток вечера был проведен в кровати за размышлениями ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ты получаешь + 2 к интелекту");
                    Console.ResetColor();
                    Console.WriteLine($"\nНажмите Enter чтобы продолжить");
                }
                else if (rezChoise1 == "2")
                {
                    characteristics[4] += 1;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"Взабравшись на стул ты рассказываешь стихотворение. Бабушка в слезах счастья, дед горд {sexFor6}");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ты получаешь + 1 к обоянию");
                    Console.ResetColor();
                    Console.WriteLine($"\nНажмите Enter чтобы продолжить");
                }
                else
                {
                    Console.WriteLine("Введите корректное значение");
                }
            }
            else if (MainCharacter.characteristics[0] == -1)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"1. Выказать недовольство подарком и попросить другой.\n2. Взять подарок и поблагодарить родителей.");
                Console.ResetColor();

                string input1 = Console.ReadLine();
                string input = Console.ReadLine();
                string rezChoise2 = InputParse.ResInputParse(input, 2);

                if (rezChoise2 == "1")
                {
                    characteristics[0] -= 1;
                    characteristics[1] += 1;
                    characteristics[2] += 1;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Ты топаешь по палу и вопишь: МАМА КАКА МАМА КАКА");
                    Console.WriteLine("Родители явно разочарованы но выдают тебе другой подарок");
                    Console.WriteLine("Это игрушенчый молоток с которым ты наудивление ловко управляешься");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ты получаешь + 1 к силе");
                    Console.WriteLine("Ты получаешь + 1 к ловкости");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ты получаешь - 1 к интелекту");
                    Console.ResetColor();
                    Console.WriteLine($"\nНажмите Enter чтобы продолжить");

                }
                else if (rezChoise2 == "2")
                {
                    characteristics[0] += 2;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Много времени пришлось провести разбераясь с игрой чтоюы победить последсвия решения принятого в дестве");
                    Console.WriteLine("Но тебе это удается");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ты получаешь + 2 к интелекту");
                    Console.ResetColor();
                    Console.WriteLine($"\nНажмите Enter чтобы продолжить");
                }
                else
                {
                    Console.WriteLine("Введите корректное значение");
                }

            }

            Console.Read();

            Console.Clear();
        }
    }
}
