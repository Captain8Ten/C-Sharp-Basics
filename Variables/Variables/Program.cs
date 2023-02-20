namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number;
            number = 0;
            Console.WriteLine(number);

            int count = 10;
            float totalPrice = 20.95f;
            double taxPercentage = .06;
            char character = 'A';
            string sentence = "I love the Cincinnati Bengals";
            bool isWorking = true;
            

            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(taxPercentage);
            Console.WriteLine(character);
            Console.WriteLine(sentence);
            Console.WriteLine(isWorking);

            // Replacing the data type with var, C# will determine the data type for you based on the data.
            // This however does not work for byte. C# will find an expect byte character as an int.
            var count1 = 10;
            var totalPrice1 = 20.95f;
            var taxPercentage1 = .06;
            var character1 = 'A';
            var sentence1 = "I love the Cincinnati Bengals";
            var isWorking1 = true;

            Console.WriteLine("");
            Console.WriteLine(count1);
            Console.WriteLine(totalPrice1);
            Console.WriteLine(taxPercentage1);
            Console.WriteLine(character1);
            Console.WriteLine(sentence1);
            Console.WriteLine(isWorking1);


            Console.WriteLine("");
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
        }
    }
}