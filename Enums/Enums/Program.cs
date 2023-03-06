
namespace Enums
{
    /*
     * Enum or enumeration is a value data type
     * It is mainly used to assign the names or string values to
     * integral constants. It makes the program easy to read. 
    */
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine(method);
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());

            var methodName = "Express";

            var shippingMethod = Enum.Parse(typeof(ShippingMethod), methodName);

            Console.WriteLine(shippingMethod);
        }
    }
}