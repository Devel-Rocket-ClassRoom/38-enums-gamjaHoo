using System;

//1
{
    Animal animal = Animal.Dog;
    switch (animal)
    {
        case Animal.Chicken:
            Console.WriteLine("닭");
            break;
        case Animal.Dog:
            Console.WriteLine("개");
            break;
        case Animal.Pig:
            Console.WriteLine("돼지");
            break;
        default:
            Console.WriteLine("알 수 없는 동물");
            break;
    }
}

//2
{
    CharacterState state = CharacterState.Attacking;
    Update();
    void Update()
    {
        switch (state)
        {
            case CharacterState.Attacking:
                Console.WriteLine("공격 애니메이션 재생");
                break;
            case CharacterState.Idle:
                Console.WriteLine("대기");
                break;
            case CharacterState.Walking:
                Console.WriteLine("걸음");
                break;
            default:
                Console.WriteLine("dd");
                break;
        }
    }
}

//3
{
    PrintItemInfo("전설의 검", ItemRarity.Legendary);
    void PrintItemInfo(string name, ItemRarity rarity)
    {
        Console.WriteLine($"아이템: {name}\n등급: {rarity}");
    }
}

//4
{
    Move(Direction.Up);
    Move(Direction.Right);
    void Move(Direction direction)
    {
        switch(direction)
        {
            case Direction.Left:
                Console.WriteLine("왼쪽으로 이동 (x-1)");
                break;
            case Direction.Right:
                Console.WriteLine("오른쪽으로 이동(x+1)");
                break;
            case Direction.Up:
                Console.WriteLine("위로 이동(y+1)");
                break;
            case Direction.Down:
                Console.WriteLine("아래로 이동(y-1)");
                break;
            default:
                Console.WriteLine();
                break;
        }
    }
}


enum Animal
{
    Chicken, Dog, Pig
}

enum CharacterState
{
    Idle,
    Walking,
    Running,
    Jumping,
    Attacking,
    Dead
}

enum ItemRarity
{
    Common,
    Uncommon,
    Rare,
    Epic,
    Legendary
}

enum Direction
{
    Up,
    Down,
    Left,
    Right
}