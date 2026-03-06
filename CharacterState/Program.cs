using System;

namespace CharacterState
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endFlag = false;
            CharacterState state = CharacterState.Idle;
            Console.WriteLine("=== 파일 권한 관리 ===\n");
            while (!endFlag)
            {
                int choice = ShowAndChoose();
                switch(choice)
                {
                    case 1:
                        ChangeStatus(ref state);
                        break;
                    case 2:
                        ShowAllStatus();
                        break;
                    case 3:
                        ShowCurrentStatus(state);
                        break;
                    case 4:
                        endFlag = true;
                        break;
                    default:
                        Console.WriteLine("1-4 사이의 숫자를 선택해주세요");
                        break;


                }
            }
        }
        static int ShowAndChoose()
        {
            Console.WriteLine("1. 상태 변경\n2. 상태 목록 보기\n3. 현재 행동 보기\n4. 종료");
            Console.Write("선택: ");
            int choice = int.Parse(Console.ReadLine());

            return choice;
        }
        static void ShowAllStatus()
        {
            Array values = Enum.GetValues(typeof(CharacterState));
            Console.WriteLine("=== 상태 목록 ===");
            foreach (var value in values)
            {
                Console.WriteLine($"{value} = {(int)value}");
            }
        }

        static void ChangeStatus(ref CharacterState state)
        {
            Console.Write("변경할 상태 번호 입력 (0-5): ");
            int choice = int.Parse(Console.ReadLine());

            state = (CharacterState)choice;
            Console.WriteLine($"상태가 {state}(으)로 변경되었습니다.");
        }

        static void ShowCurrentStatus(CharacterState state)
        {
            switch(state)
            {
                case CharacterState.Idle:
                    Console.WriteLine($"[행동] 가만히 있기");
                    break;
                case CharacterState.Walking:
                    Console.WriteLine("[행동] 걷습니다");
                    break;
                case CharacterState.Attacking:
                    Console.WriteLine("[행동] 적을 공격합니다!");
                    break;
                case CharacterState.Running:
                    Console.WriteLine("[행동] 달립니다!");
                    break;
                case CharacterState.Jumping:
                    Console.WriteLine("[행동] 점프합니다!");
                    break;
                case CharacterState.Dead:
                    Console.WriteLine("[행동] 사망 상태입니다. 행동할 수 없습니다.");
                    break;
                default:
                    Console.WriteLine("0-5 사이의 숫자를 선택해주세요");
                    break;
            }
        }
    }
}