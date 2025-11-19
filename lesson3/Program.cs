namespace lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool boolWhile = true;
            try
            {

                while (boolWhile)
                { 
                    Console.WriteLine("1 - сложение, 2 - вычитание, 3 - деление, 4 - умножение, 5 - остаток от деления, 6 - квадратный корень, 7 - выход");
                    string answerStart = Console.ReadLine();
                    switch (answerStart)
                    {
                        case "1":
                            double numberOne, numberTwo;
                            inputNumbers(out numberOne, out numberTwo);
                            Console.WriteLine("Ответ: " + (numberOne + numberTwo));
                            break;
                        case "2":
                            inputNumbers(out numberOne, out numberTwo);
                            Console.WriteLine("Ответ: " + (numberOne - numberTwo));
                            break;
                        case "3":
                            inputNumbers(out numberOne, out numberTwo);
                            Console.WriteLine("Ответ: " + (numberOne / numberTwo));
                            break;
                        case "4":
                            inputNumbers(out numberOne, out numberTwo);
                            Console.WriteLine("Ответ: " + (numberOne * numberTwo));
                            break;
                        case "5":
                            inputNumbers(out numberOne, out numberTwo);
                            Console.WriteLine("Ответ: " + (numberOne % numberTwo));
                            break;
                        case "6":
                            inputNumbers(out numberOne);
                            Console.WriteLine("Ответ: " + Math.Sqrt(numberOne));
                            break;
                        case "7":
                            boolWhile = false;
                            break;
                        default:
                            Console.WriteLine("Неверный ввод.");
                            break;
                    }
                }
            }
            catch { }
        }

        private static void inputNumbers(out double numberOne, out double numberTwo)
        {
            while (true)
            {
                Console.WriteLine("Введите первое число: ");
                bool tryParseTextOne = double.TryParse(Console.ReadLine(), out numberOne);
                Console.WriteLine("Введите второе число: ");
                bool tryParseTextTwo = double.TryParse(Console.ReadLine(), out numberTwo);
                if (tryParseTextOne == true && tryParseTextTwo == true)
                {
                    break;
                }
                else Console.WriteLine("Неверный ввод.");
            }
        }
        private static void inputNumbers(out double numberOne)
        {
            while (true)
            {
                Console.WriteLine("Введите число: ");
                bool tryParseTextOne = double.TryParse(Console.ReadLine(), out numberOne);
                if (tryParseTextOne == true)
                {
                    break;
                }
                else Console.WriteLine("Неверный ввод.");
            }
        }
    }
}
