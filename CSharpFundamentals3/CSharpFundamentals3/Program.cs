


namespace CSharpFundamentals3
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Luis";
            var lastName = "Medina";


            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);


            var names = new string[3] { "John", "Jack", "Mary" };

            var formattedNames = string.Join(",", names);

            Console.WriteLine(formattedNames);

            var text="Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            Console.WriteLine(text);

            /*
             Another form:
           @"Hi John
            Look into the following paths
            c:\folder1\folder2
            c:\folder3\folder4";
            */

        }
    }
}
