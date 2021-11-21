using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace textGameStory.chapters
{
    public class COne
    {
        public static void C1(ref string characterName, ref string sex)
        {
            Lists lists = new Lists();
            Random random = new Random();
            ChapterStart.ChapStart(1);


            Console.WriteLine("А кого бы ты хотел, мальчика или девочку?" + "\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("1. Мальчика" + "\n" + "2. Девочку");
            Console.ResetColor();

            string rezChoise1 = InputParse.ResInputParse(Console.ReadLine(), 2);
            if (rezChoise1 == "1")
            {
                string name = lists.names[random.Next(1, 4)];
                Console.WriteLine("Хм, окей. А как тебе имя " + name + "\n");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("1. Нормально" + "\n" + "2. Ты серьезно?");
                Console.ResetColor();
                string rezChoise2 = InputParse.ResInputParse(Console.ReadLine(), 2);
                if (rezChoise2 == "1")
                {
                    Console.WriteLine("Вообще, это была шутка, но раз тебе нравится, пусть будет так.");

                    characterName = name;
                    sex = "man";
                }
                else
                {
                    Console.WriteLine("Раз тебе не нравиться мой вариант, то предложи свой" + "\n");

                    characterName = Console.ReadLine();
                    sex = "man";

                    Console.WriteLine($"Серьезно считаешь, что {characterName} лучше чем {name} ?");
                    Console.WriteLine("Ладно, пускай будет по твоему");

                }
            }
            else if (rezChoise1 == "2")
            {
                string name = lists.names[random.Next(5, 8)];
                Console.WriteLine("Хм, окей. А как тебе имя " + name + "\n");
                Console.WriteLine("1. Нормально" + "\n" + "2. Ты серьезно?");
                string rezChoise2 = InputParse.ResInputParse(Console.ReadLine(), 2);
                if (rezChoise2 == "1")
                {
                    Console.WriteLine("Вообще, это была шутка, но раз тебе нравится, пусть будет так.");

                    characterName = name;
                    sex = "woman";

                }
                else
                {

                    Console.WriteLine("Раз тебе не нравиться мой вариант, то предложи свой" + "\n");

                    characterName = Console.ReadLine();
                    sex = "woman";

                    Console.WriteLine($"Серьезно считаешь, что {characterName} лучше чем {name} ?");
                    Console.WriteLine("Ладно, пускай будет по твоему");
                }
            }
            else
            {
                Console.WriteLine("Введите корректное значение");
            }

            Thread.Sleep(3000);

            Console.Clear();

        }
    }
}
