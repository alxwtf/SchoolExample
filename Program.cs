using System;

namespace SchoolExample
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = Input();
            float b = Input();
            Calculator(a, b);
        }
        
        static void Calculator(float a, float b)
        {
            var num = new Numbers(a, b);
            char x;
            Console.WriteLine("1. Сложить(+)\n2. Вычесть(-)\n3. Умножить(*)\n4. Поделить(/)");
            char.TryParse(Console.ReadLine(), out x);
            switch (x)
            {
                case '+':
                    {
                        num.Add();
                        break;
                    }
                case '-':
                    {
                        num.Substract();
                        break;
                    }
                case '*':
                    {
                        num.Multiply();
                        break;
                    }
                case '/':
                    {
                        b=num.Divide();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Такого действия не существует");
                        break;
                    }
            }
            Console.WriteLine("Выберите дальнейшее действие");
            Console.WriteLine("1: Ввести новые числа\n2: Выбрать другое действие с числами");
            int.TryParse(Console.ReadLine(), out var answer);
            switch (answer)
            {
                case 1:
                    {
                        a = Input();
                        b = Input();
                        Calculator(a, b);
                        break;
                    }
                case 2:
                    {
                        Calculator(a, b);
                        break;
                    }
                default: break;
            }
        }

        static float Input()
        {
            float a;
            Console.WriteLine("Введите число");
            while (!float.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Некорректный ввод, введите число");
            }
            return a;
        }
    }
}
