using System;

namespace MaximumProblemUsingGenerics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" TO Find Maximum Value Using Generics");
            int value = MaximumNumberCheck.MaximumIntegerNumber(10, 12, 13);
            Console.WriteLine(value);
        }
    }
}
