namespace LAB1_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction[] fractions = new Fraction[]
        {
            new Fraction(3, 4),
            new Fraction(1, 2),
            new Fraction(5, 6),
        };

            Console.WriteLine("Array Before :");
            foreach (Fraction fraction in fractions)
            {
                Console.WriteLine(fraction);
            }

            Array.Sort(fractions);

            Console.WriteLine("\nArray After Sort :");
            foreach (Fraction fraction in fractions)
            {
                Console.WriteLine(fraction);
            }
        }
    }
}