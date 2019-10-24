using System;

class Numbers
{
    public float firstNumber { get; set; }
    public float secondNumber { get; set; }
    public float result { get; set; }

    public Numbers(float a, float b)
    {
        firstNumber = a;
        secondNumber = b;
    }
    public float Add()
    {
        result=firstNumber+secondNumber;
        Console.WriteLine($"{firstNumber}+{secondNumber}\nОтвет: {result}");
        return result;
    }

    public float Substract()
    {
        result=firstNumber-secondNumber;
        Console.WriteLine($"{firstNumber}-{secondNumber}\nОтвет: {result}");
        return result;
    }

    public float Multiply()
    {
        result=firstNumber*secondNumber;
        Console.WriteLine($"{firstNumber}*{secondNumber}\nОтвет: {result}");
        return result;
    }
    public (float secondNum,float res) Divide()
    {
        float temp;
        
        while (secondNumber == 0)
        {
            Console.WriteLine($"Деление на ноль, введите другое число");
            float.TryParse(Console.ReadLine(), out temp);
            secondNumber = temp;
        }
        result=firstNumber/secondNumber;
        return (secondNum:secondNumber,res:result);
    }
}