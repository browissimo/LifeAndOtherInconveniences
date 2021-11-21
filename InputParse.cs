using System;

namespace textGameStory
{
    public static class InputParse
    {
        public static string ResInputParse(string input, int numerOfChoices)
        {
            bool tryResult;
            string wrongAnswer = $"Введите корректное значение в пределах от 1 до {numerOfChoices}\n" +
                $"Для просмотра характеристик нажмите 0";

            tryResult = int.TryParse(input, out int choice);
            if (tryResult == true)
            {
                if (choice == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"\n1. Содержимое рюкзака\n" +
                        $"2. Количество здоровья\n" +
                        $"3. Характеристики");


                    bool tryResultLow = int.TryParse(Console.ReadLine(), out int lowChouce);
                    if (tryResultLow == true)
                    {
                        if (lowChouce == 1)
                        {
                            if (MainCharacter.bag == null)
                            {
                                Console.WriteLine("Рюкзак пуст");
                                Console.ResetColor();
                                return ResInputParse(Console.ReadLine(), numerOfChoices);
                            }
                            else
                            {
                                foreach (var item in MainCharacter.bag)
                                {
                                    Console.WriteLine("Содержимое инвентаря:");
                                    Console.WriteLine(item + "\n");
                                    Console.WriteLine("\nНажмите Enter чтобы продолжить");
                                    Console.ResetColor();
                                    return ResInputParse(Console.ReadLine(), numerOfChoices);
                                }
                            }
                        }
                        else if (lowChouce == 2)
                        {
                            Console.WriteLine("Количество здоровья: " + MainCharacter._hp);
                            Console.WriteLine("\nНажмите Enter чтобы продолжить");
                            Console.ResetColor();
                            return ResInputParse(Console.ReadLine(), numerOfChoices);
                        }
                        else if (lowChouce == 3)
                        {
                            Console.WriteLine($"Интелект равен: {MainCharacter.characteristics[0]}");
                            Console.WriteLine($"Сила равна: {MainCharacter.characteristics[1]}");
                            Console.WriteLine($"Ловкость равна: {MainCharacter.characteristics[2]}");
                            Console.WriteLine($"Удача равна: {MainCharacter.characteristics[3]}");
                            Console.WriteLine($"Обояние равно: {MainCharacter.characteristics[4]}");
                            Console.WriteLine("\nНажмите Enter чтобы продолжить");
                            Console.ResetColor();
                            return ResInputParse(Console.ReadLine(), numerOfChoices);
                        }
                        else
                        {
                            Console.WriteLine("Введите правильное значение");
                            Console.ResetColor();
                            return ResInputParse(Console.ReadLine(), numerOfChoices);
                        }
                    }

                    return "0";
                }
                else if (choice <= numerOfChoices && choice > 0)
                {
                    return Convert.ToString(choice);
                }
                else
                {

                    while (choice > numerOfChoices || choice < 0)
                    {
                        Console.WriteLine(wrongAnswer);
                        return ResInputParse(Console.ReadLine(), numerOfChoices);
                    }
                    return Convert.ToString(choice);
                }

            }
            else
            {
                Console.WriteLine(wrongAnswer);
                return ResInputParse(Console.ReadLine(), numerOfChoices);
            }

        }
    }
}
