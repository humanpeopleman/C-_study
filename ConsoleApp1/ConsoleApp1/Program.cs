using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //다차원 배열
            int[,] 이차원배열 = new int[3, 3];
            이차원배열[0, 0] = 1;
            Console.WriteLine(이차원배열[0, 0]);
            int[,] 이차원배열2 = new int[2, 3]
            {
                {1, 2, 3 },
                {4, 5, 6 }
            };
            Console.WriteLine(이차원배열2[1, 2]);

            //가변 배열
            int[][] 가변배열 = new int[2][];
            가변배열[0] = new int[3];
            가변배열[1] = new int[1];

            //switch 문
            char ch = 'F';
            
            switch (ch)
            {
                case 'M':
                    Console.WriteLine("남성");
                    break;

                case 'F':
                    Console.WriteLine("여성");
                    break;
                default:
                    Console.WriteLine("알 수 없음");
                    break;
            }

            string text = "C#";

            switch (text)
            {
                case "C#":
                case "VB.NET":
                    Console.WriteLine(".NET 호환 언어");
                    break;

                default:
                    Console.WriteLine("알 수 없음");
                    break;
            }

            //continue 문
            int sum = 0;
            int n = 1;

            while (n ++ <= 10)
            {
                if ((n % 2) != 0)
                {
                    continue;
                }
                sum += n;
            }
        }                                                                  
    }
}
   