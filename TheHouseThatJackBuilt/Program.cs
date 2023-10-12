using System.Collections.Immutable;

namespace TheHouseThatJackBuilt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part1 part1 = new Part1();
            Part2 part2 = new Part2();
            Part3 part3 = new Part3();
            Part4 part4 = new Part4();
            Part5 part5 = new Part5();
            Part6 part6 = new Part6();
            Part7 part7 = new Part7();
            Part8 part8 = new Part8();
            Part9 part9 = new Part9();

            var poem1 = part1.AddPart(ImmutableList<string>.Empty);
            var poem2 = part2.AddPart(poem1);
            var poem3 = part3.AddPart(poem2);
            var poem4 = part4.AddPart(poem3);
            var poem5 = part5.AddPart(poem4);
            var poem6 = part6.AddPart(poem5);
            var poem7 = part7.AddPart(poem6);
            var poem8 = part8.AddPart(poem7);
            var finalPoem = part9.AddPart(poem8);
            foreach (var line in finalPoem)
            {
                Console.WriteLine(line);
            }
        }
    }
}