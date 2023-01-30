namespace MyProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.output
            Console.Write("Hey");
            Console.Write("back\b");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Bro\nCode");
            Console.WriteLine("back\ba");
            Console.Write("a\t\vb");

            //2.variables
            int x; //declaration
            x = 123; //initialization

            int y = 321;

            int z = x + y;

            int age = 21;//whole integer
            double height = 300.5;//decimal number
            bool alive = true;
            char symbol = '@';
            string name = "1peach";

            Console.WriteLine("Hello " + name);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine("your age is " + age);
            Console.WriteLine("your height is " + height + "cm");
            Console.WriteLine("are you alive? " + alive);
            Console.WriteLine("your symbol is " + symbol);

            string userName = symbol + name;
            Console.WriteLine("Your username is: " + userName);

            //3.constants
            const double pi = 3.141592;
            Console.WriteLine(pi);

            //4.type casting
            double a = 3.14;
            int b = Convert.ToInt32(a);
            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());

            //5.user input
            Console.WriteLine("Whats your name?");
            string Name = Console.ReadLine();
            Console.WriteLine("Hello!" + Name);

            //6.arithmetic operators
            int friends = 10;
            Console.WriteLine(friends);
            int remainder = friends % 3;
            Console.WriteLine(remainder);

            //7.Math class
            double q = 2;
            double w = Math.Pow(q, 3);
            double e = Math.Sqrt(w);
            Console.WriteLine(w);
            Console.WriteLine(e);

            Console.ReadKey();
        }
    }
}