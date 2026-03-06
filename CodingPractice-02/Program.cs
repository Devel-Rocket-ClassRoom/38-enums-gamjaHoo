using System;


//1
{
    Console.WriteLine($"Animal.Dragon: {(int)Animal.Dragon}, {Animal.Dragon}");
}

//2
{
    Array values = Enum.GetValues(typeof(Priority));
    Console.WriteLine("Priority 열거형의 값들: ");
    foreach( var value in values)
    {
        Console.WriteLine($"{value} = {(int)value}");
    }
}


enum Animal
{
    Rabbit,
    Dragon,
    Snake
}

enum Priority
{
    High = 1,
    Normal = 5,
    Low = 10
}