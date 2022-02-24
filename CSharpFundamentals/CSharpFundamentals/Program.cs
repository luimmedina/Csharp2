
using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Person luis = new Person();
            luis.FirstName = "Luis";
            luis.LastName = "Medina";
            luis.Introduce();

            Age age = new Age();
            var ageperson = age.AgePerson(17);

            Console.WriteLine("My Age is " + ageperson);
        }
    }
}