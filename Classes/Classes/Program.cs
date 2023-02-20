using Classes.Math;

namespace Classes
{
    public class Person
    {
        public string fName;
        public string lName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + fName + " " + lName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.fName = "Tony";
            person.lName = "Stark";
            person.Introduce();

            Calculator calculator = new Calculator();

            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}