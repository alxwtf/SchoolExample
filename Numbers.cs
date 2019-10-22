using System;

class Numbers
{
    public float firstNumber { get; set; }
    public float secondNumber { get; set; }

    public Numbers(float a, float b)
    {
        firstNumber = a;
        secondNumber = b;
    }
    public void Add()
    {
        Console.WriteLine($"{firstNumber}+{secondNumber}\nОтвет: {firstNumber + secondNumber}");
    }

    public void Substract()
    {
        Console.WriteLine($"{firstNumber}-{secondNumber}\nОтвет: {firstNumber - secondNumber}");
    }

    public void Multiply()
    {
        Console.WriteLine($"Ответ: {firstNumber * secondNumber}");
    }
    public float Divide()
    {
        float temp;
        while (secondNumber==0)
        {
            Console.WriteLine($"Деление на ноль, введите другое число");
            float.TryParse(Console.ReadLine(),out temp);
            secondNumber=temp;
        }
        Console.WriteLine($"Ответ: {firstNumber / secondNumber}");
        return secondNumber;
    }
}