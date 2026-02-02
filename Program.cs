namespace Y9ConcatenationTaskAGS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FirstName;
            Console.Write("Enter first name: ");
            FirstName = Console.ReadLine();
            string lastname;
            Console.Write("Enter last name: ");
            lastname = Console.ReadLine();
            Console.Write("Enter age: ");
             string age1 = Console.ReadLine();
            int age = Convert.ToInt32(age1);
            Console.WriteLine("hello " + FirstName + " " + lastname + " you are " + age + " years old");

            // add two more variables for the users last name and their age
            // take these inputs into the program
            // use the test data Bob, Smith, 14
            // ammend this code to output in one command
            // Hello Bob Smith you are 14 years old
            // save and commit your program
            // add evidence of the test input and your own input running the program 
        }
    }
}
