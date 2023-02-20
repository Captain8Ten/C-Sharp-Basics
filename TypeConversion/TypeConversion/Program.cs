namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is fine because byte is 1 byte and int is 4 bytes. 
            // The maximum byte is smaller than the maximum int
            byte b = 1;
            int i = b;
            Console.WriteLine(i);
            Console.WriteLine("");

            // This is not okay because the maximum int is larger than the maximum byte
            // In a situation like this, type casting is needed
            int i2 = 1;
            byte b2 = (byte) i2;
            Console.WriteLine(b2);
        }
    }
}