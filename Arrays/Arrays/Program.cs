namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Could also use var to declare, the compiler will know
            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
        }
    }
}
