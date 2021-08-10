using System;

namespace Ex_3 //Яковлев Сеогей
{
    class Program
    {
       
        
        
        static int GetInt()
            {
                while (true)
                    if (!int.TryParse(Console.ReadLine(), out int x))
                        Console.Write("Неверный ввод (требуется числовое значение).\nПожалуйста, повторите ввод: ");
                    else return x;
            }
            
            static int CheckExeptionByInput()
            {
                int result = 0;
                bool exceptionCatched;
                do
                {
                    exceptionCatched = false;
                    try
                    {
                        result = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        exceptionCatched = true;
                        string message = ex.Message;
                        Console.WriteLine("Возникло исключение: " + message);
                        Console.Write("Пожалуйста, повторите ввод: ");
                    }

                } while (exceptionCatched);
                return result;
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Вас приветствует программа подсчета нечетных положительных чисел");
                Console.WriteLine("Вводите числа по одному, для завершения введите 0: ");

                int AmountOfOddNumbers = 0;
                while (true)
                {
                    int number = CheckExeptionByInput();
                    if (number == 0)
                    {
                        break;
                    }
                    else if (number > 0 && number % 2 == 1)
                    {
                        AmountOfOddNumbers++;
                    }
                }

                Console.WriteLine(Environment.NewLine + "Количество чисел: " + AmountOfOddNumbers);

                Console.ReadKey();
            }
        
    }
}
    

