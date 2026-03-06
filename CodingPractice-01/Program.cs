using System;



//1
{
Priority p = Priority.High;
if (p == Priority.High) Console.WriteLine("높은 우선순위");
}

//2
{
    Animal a = Animal.Tiger;
    Console.WriteLine(a);
    if (a == Animal.Tiger) Console.WriteLine("호랑이");
}

//3
{
    Console.WriteLine($"Red: {(int)Color.Red}, Green: {(int)Color.Green}, Blue: {(int)Color.Blue}");
}

//4
{
    Console.WriteLine(sizeof(SmallEnum));
}

//5
{
    Type ColorType = typeof(ConsoleColor);
    string[] Colors = (Enum.GetNames(ColorType));
    Console.WriteLine("ConsoleColor 열거형의 색상들: ");
    for(int i = 0; i < Colors.Length; i++)
    {
        Console.WriteLine(Colors[i]); 
    }
}

//6
{
    string red = "Red";
    ConsoleColor color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), red);
    Console.ForegroundColor = color;
    Console.WriteLine("빨간색 테스트");
    Console.ResetColor();
    Console.WriteLine("기본 색상 테스트");

}

//7
{
    string up = "Up";
    if(Enum.TryParse(up, out Direction direction))
    {
        Console.WriteLine($"변환 성공: {direction}");

    }
    else
    {
        Console.WriteLine($"\'{up}\'은(는) 유효하지 않은 값");
    }
    string forward = "Forward";
    if (Enum.TryParse(forward, out Direction direction2))
    {
        Console.WriteLine($"변환 성공: {direction2}");

    }
    else
    {
        Console.WriteLine($"\'{forward}\'은(는) 유효하지 않은 값");
    }
}

//8
{
    bool isValid1 = Enum.IsDefined(typeof(Animal), 1);
    Console.WriteLine($"1은 유효한 Animal 값인가? {isValid1}");

    bool isValid2 = Enum.IsDefined(typeof(Animal), 100);
    Console.WriteLine($"100은 유효한 Animal 값인가? {isValid2}");

    bool isValid3 = Enum.IsDefined(typeof(Animal), "Tiger");
    Console.WriteLine($"'Tiger'는 유효한 Animal 값인가? {isValid3}");
}

//9
{
    Direction dir = Direction.Right;
    Console.WriteLine($"{dir} = {(int)dir}");
    int two = 2;
    Console.WriteLine($"{two} = {(Direction)two}");
}

//10
{
    Console.WriteLine((Animal)100);
}




enum Priority
{
    High,
    Normal,
    Low
}

enum Animal
{
    Mouse,
    Cow,
    Tiger
}

enum Color
{
    Red = 10,
    Green,
    Blue = 20
}

enum SmallEnum : byte
{
    Left,
    Right,
    Top,
    Bottom
}

enum Direction
{
    Up,
    Down,
    Left,
    Right
}