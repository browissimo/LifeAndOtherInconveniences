using System;
using System.Threading;

namespace textGameStory.chapters
{
    public class CTwo
    {
        static string SexFor3;
        static string SexFor0;
        public static void C2(ref string name, ref string sex, ref int hp, ref int[] characteristics)
        {
            ChapterStart.ChapStart(2);
            if (sex == "man")
                SexFor3 = "его";
            else
                SexFor3 = "ее";

            if (sex == "man")
                SexFor0 = "ОН";
            else
                SexFor0 = "ОНА";


            string[] dialog = new string[8];
            dialog[0] = $"СУКААААА ААААА. {SexFor0} МЕНЯ ВСЮ РАЗОРВЕТ";
            dialog[1] = "МНЕ НЕ ГОВОРИЛИ, ЧТО БУДЕТ НАСТОЛЬКО БОЛЬНО";
            dialog[2] = "Успокойтесь, пожалуйста, постарайтесь дышать ровно";
            dialog[3] = $"Успокоится? Докторишко ты недоделанный СУКА.\n Сейчас я " +
                $"выпихаю {SexFor3} из себя и мы посмотрм кто тут не спокоен";
            dialog[4] = "Дорогая, успокойся, постарайся вести себя прилично";
            dialog[5] = "Просто заткнись или иди на хер. Тоже мне дорогой";
            dialog[6] = "Поциенточка, я уже вижу про...";
            dialog[7] = "ММММАААААА КАК ЖЕ БОЛЬНО";

            foreach (var phrase in dialog)
            {
                Console.WriteLine(phrase);
                Console.WriteLine("");
                Thread.Sleep(3000);
            }
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Ну что же, это ваш первый выход в свет.");
            Console.WriteLine("И сразу перед вами стоит выбор: пролезть головой вперед," + "" +
                "это будет явно дольше, но безопаснее.\nИли можно повернуться ногами. Должно выйти быстрее.");

            Thread.Sleep(3000);

            Console.WriteLine($"\n1. Головой вперед \n2. Ногами вперед \n");
            Console.ResetColor();

            string rezChoise1 = InputParse.ResInputParse(Console.ReadLine(), 2);

            if (rezChoise1 == "1")
            {
                characteristics[0] += 1;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Ты устремляешься головой в проход, упершись ногами в то, что осталось от матки.\n" +
                    $"Как и предполагалось, вышло долго, но безопасно и относително гладко \n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ты получаешь + 1 к интелекту");
                Console.ResetColor();
                Console.WriteLine($"\nНажмите Enter чтобы продолжить");
            }
            else if (rezChoise1 == "2")
            {
                characteristics[0] -= 1;
                characteristics[2] += 1;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Переворот, рывок, ты шустро выскальзываешь в отверсите и появляешься на свет\n" +
                    $"Вышло неплохо, но стоит дважды подумать перед тем, как принимать подобыне решения");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ты получаешь + 1 к ловкости");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ты получаешь - 1 к интелекту");
                Console.ResetColor();
                Console.WriteLine($"\nНажмите Enter чтобы продолжить");
            }
            else
            {
                Console.WriteLine("Введите корректное значение");
            }
            Console.Read();

            Console.Clear();
        }
    }
}
