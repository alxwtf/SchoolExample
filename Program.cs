using System;

namespace SchoolExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var History = new string[8000000];
            var count = 0;
            float a = Input();
            float b = Input();
            Calculator(a, b, History, count);
        }

        static void Calculator(float a, float b, string[] story, int count)
        {
            var num = new Numbers(a, b);
            char x;
            float rslt = 0;
            Console.WriteLine("\nКакую операцию произведём над числами ?");
            Console.WriteLine("1. Сложить(+)\n2. Вычесть(-)\n3. Умножить(*)\n4. Поделить(/)");
            char.TryParse(Console.ReadLine(), out x);
            switch (x)
            {
                case '+':
                    {
                        rslt = num.Add();
                        story[count] = $"{a} + {b} = {rslt}";
                        count++;
                        break;
                    }
                case '-':
                    {
                        rslt = num.Substract();
                        story[count] = $"{a} - {b} = {rslt}";
                        count++;
                        break;
                    }
                case '*':
                    {
                        rslt = num.Multiply();
                        story[count] = $"{a} * {b} = {rslt}";
                        count++;
                        break;
                    }
                case '/':
                    {
                        b = num.Divide().secondNum;
                        rslt = num.Divide().res;
                        Console.WriteLine($"{a} / {b} = {rslt}");
                        story[count] = $"{a} / {b} = {rslt}";
                        count++;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Такого действия не существует");
                        break;
                    }
            }
            var answer = 0;
            do
            {
                Console.WriteLine("Выберите дальнейшее действие");
                Console.WriteLine("1: Ввести новые числа\n2: Выбрать другое действие с числами");
                Console.WriteLine("3: Произвести вычисление над ответом(ответ первое число)\n4: Произвести вычисление над ответом(ответ второе число)");
                Console.WriteLine("5: Показать историю вычислений\n6: Выход");
                Console.WriteLine();
                int.TryParse(Console.ReadLine(), out answer);
                switch (answer)
                {
                    case 1:
                        {
                            a = Input();
                            b = Input();
                            Calculator(a, b, story, count);
                            break;
                        }
                    case 2:
                        {
                            Calculator(a, b, story, count);
                            break;
                        }
                    case 3:
                        {
                            b = Input();
                            Calculator(rslt, b, story, count);
                            break;
                        }
                    case 4:
                        {
                            a = Input();
                            Calculator(a, rslt, story, count);
                            break;
                        }
                    case 5:
                        {
                            History(story, count);
                            continue;
                        }
                    default: { break; }
                }
            } while (answer != 6);
            Console.WriteLine("\nСпасибо за использование");
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

        static void History(string[] story, int count)
        {
            Console.WriteLine("\nВведенные вами операции");
            for (var i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}. {story[i]}");
            }
            Console.WriteLine();
        }
    }
}
