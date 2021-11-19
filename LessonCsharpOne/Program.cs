namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt1.Length);

            string txtHello = "Hello World";
            Console.WriteLine(txtHello.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txtHello.ToLower());   // Outputs "hello world"

            string firstName1 = "John ";
            string lastName1 = "Doe";
            string name1 = string.Concat(firstName1, lastName1);
            Console.WriteLine(name1);

            string firstName = "John";
            string lastName = "Doe";
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name1);

            string myString = "Hello";
            Console.WriteLine(myString[0]);  // Outputs "H"

            Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"

            // Full name
            string name3 = "John Doe";

            // Location of the letter D
            int charPos = name3.IndexOf("D");

            // Get last name
            string lastName3 = name3.Substring(charPos);

            // Print the result
            Console.WriteLine(lastName3);

            //\'	'    Single quote
            //\"	"    Double quote
            //\\	\	Backslash

            //\n New Line
            //\t Tab	
            //\b Backspace
        }
    }
}