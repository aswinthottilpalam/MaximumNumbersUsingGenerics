using System;

namespace MaximumProblemUsingGenerics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" TO Find Maximum Value Using Generics");
            int value = MaxNumCheck.MaximumIntegerNumber(10, 12, 13);
            Console.WriteLine(value);
            Console.WriteLine("Find MaxValue Float");
            double floatValue = MaxNumCheck.MaximumFloatNumber(55.5, 22.2, 33.3);
            Console.WriteLine(floatValue);
        }
    }
}
