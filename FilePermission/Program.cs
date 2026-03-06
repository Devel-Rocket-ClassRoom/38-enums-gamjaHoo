using System;

namespace FilePermission
{
    class Program
    {
        static void Main(string[] args)
        {
            FilePermission fp = FilePermission.None;
            Console.WriteLine("=== 파일 권한 관리 ===");
            Console.WriteLine();
            Console.WriteLine($"현재 권한: {fp}\n");
            Console.WriteLine("[권한 추가]");
            fp |= FilePermission.Read;
            Console.WriteLine($"+ Read 추가: {fp}");
            fp |= FilePermission.Write;
            Console.WriteLine($"+ Write 추가: {fp}");
            fp |= FilePermission.Execute;
            Console.WriteLine($"+ Execute 추가: {fp}");
            Console.WriteLine("\n[권한 확인]");
            Console.WriteLine($"Read 권한: {HasFlag(FilePermission.Read)}");
            Console.WriteLine($"Write 권한: {HasFlag(FilePermission.Write)}");
            Console.WriteLine($"Execute 권한: {HasFlag(FilePermission.Execute)}");

            Console.WriteLine("\n[권한 제거]");
            fp &= ~FilePermission.Write;
            Console.WriteLine($"- Write 제거: {fp}");

            Console.WriteLine("\n[제거 후 확인]");
            Console.WriteLine($"Read 권한: {HasFlag(FilePermission.Read)}");
            Console.WriteLine($"Write 권한: {HasFlag(FilePermission.Write)}");
            Console.WriteLine($"Execute 권한: {HasFlag(FilePermission.Execute)}");

            bool HasFlag(FilePermission flag)
            {
                return (fp & flag)!=0;
            }
        }
    }
}