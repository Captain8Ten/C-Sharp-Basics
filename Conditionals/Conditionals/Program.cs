namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;

            if(hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning!");
            }else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's evening!");
            }else
            {
                Console.WriteLine("It's night!");
            }

            section2();
            section3();
            SeasonController.section4();
        }

        public static void section2()
        {
            bool isGoldCustomer = true;
            float price;

            if(isGoldCustomer)
            {
                price= 19.95f;
            }else
            {
                price = 29.95f;
            }

            Console.WriteLine(price);
        }

        public static void section3()
        {
            bool isGoldCustomer = false;
            
            /*
             * float price = declare a variable
             * (isGoldCustomer) = conditional statement
             * ? = stating that this is a conditional statement
             * 19.95f = if conditional succeeds
             * 29.95f = if conditional does not succeed 
             */
            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);
        }
    }
}