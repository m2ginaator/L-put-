using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Lõputöö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta soovitud meetod");

            string method = Console.ReadLine();

            switch (method)
            {
                case "average":
                    AverageLINQ();
                    break;

                case "any":
                    AnyLINQ();
                    break;

                case "skipwhile":
                    SkipWhileLINQ();
                    break;

                case "repeat":
                    RepeatLINQ();
                    break;

                case "forloop":
                    ForLoop();
                    break;

                default:
                    break;
            }
        }

        public static void AverageLINQ()
        {
            Console.WriteLine("\n----AverageLINQ----");

            var averageResult = HumanList.people
                .Average(x => x.Age);

            Console.WriteLine(averageResult);
        }

        public static void AnyLINQ()
        {
            Console.WriteLine("\n----AnyLINQ-----");

            bool anyOver21 = HumanList.people
                .Any(x => x.Age > 21);

            Console.WriteLine(anyOver21);
        }

        public static void SkipWhileLINQ()
        {
            Console.WriteLine("\n----SkipWhile----");

            var skipWhile = HumanList.people
                .SkipWhile(x => x.Age < 20);

            foreach (var item in skipWhile)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
        }

        public static void RepeatLINQ()
        {
            Console.WriteLine("\n-----RepeatLINQ----");

            IEnumerable<int> ones = Enumerable.Repeat(1, 5);
            string numberList = string.Join(",", ones);

            Console.WriteLine(numberList);
        }

        public static void ForLoop()
            {
                Console.WriteLine("Püramiid");
                Console.WriteLine("Sisesta püramiidi suurus: ");
                int rows = Convert.ToInt32(Console.ReadLine());
                int spc = rows + 4 - 1;

                for (int i = 1; i <= rows; i++)
                {
                    Console.Write("\n");
                    for (int k = spc; k >= 1; k--)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("* ");
                    }
                    spc--;
                }
            }
        }
    }


