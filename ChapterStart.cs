using System;

namespace textGameStory
{
    public static class ChapterStart
    {
        public static void ChapStart(int _number)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"ГЛАВА {_number}");
            Console.ResetColor();
        }
    }
}
