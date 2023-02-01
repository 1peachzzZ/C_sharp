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

            //8.random numbers
            Random random = new();
            int r = random.Next(0, 10);
            double t = random.NextDouble();
            Console.WriteLine(r);
            Console.WriteLine(t);

            //9.hypotenuse calculator
            double edge1 = 3.0;
            double edge2 = 4.0;
            Console.WriteLine(Math.Sqrt((edge1 * edge1) + (edge2 * edge2)));

            //10.string method
            string fullName = "Bro Code";
            fullName = fullName.ToUpper();
            fullName = fullName.ToLower();
            string phoneNumber = "123-456-7890";
            phoneNumber = phoneNumber.Replace("-", "/");
            string username = fullName.Insert(0, "@");
            Console.WriteLine(fullName);
            Console.WriteLine(phoneNumber);
            Console.WriteLine(username);
            Console.WriteLine(phoneNumber.Length);
            string firstname = fullName[..3];
            string lastname = fullName.Substring(4, 3);
            Console.WriteLine(firstname);
            Console.WriteLine(lastname);

            //11.if statements
            int ages = 31;
            if (ages == 31)
            {
                Console.WriteLine("ok");
            }

            //12.switches

            switch (ages)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("if wrong");
                    break;
            }
            //13.logical operators
            double temp = 36.5;
            if (temp > 0 && temp < 100 || temp == 36.5)
            {
                Console.WriteLine("ok");
            }

            //14.while loops
            string name1 = "";
            while (name1 == "")
            {
                Console.WriteLine("Enter your name:");
                name1 = Console.ReadLine();
            }

            //15.for loops
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
            }

            //16.nested loops

            for (int i = 0; i < 10; i++)
            {
                while (true)
                {
                    break;
                }
            }

            //17.number guessing game
            Random random1 = new();
            bool playagain = true;
            int min = 1;
            int max = 100;
            int guess;
            int guesses;
            int number;
            string res;
            while (playagain)
            {
                guess = 0;
                guesses = 0;
                number = random1.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + "-" + max + ":");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);
                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is to high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is to low!");
                    }
                    guesses++;
                }
                Console.WriteLine("number: " + number);
                Console.WriteLine("you win!");
                Console.WriteLine("guesses: " + guesses);
                Console.WriteLine("play again?(y/n):");
                try
                {
                    res = Console.ReadLine();
                    res = res.ToUpper();
                    if (res == "Y")
                    {
                        playagain = true;
                    }
                    else
                    {
                        playagain = false;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("error!");
                }



            }

            //18.rock-paper-scissors game
            //19.arrays
            string[] car = new string[3];
            Console.WriteLine(car);
            string[] cars = { "BMW", "Mustang", "Corvette" };

            Console.WriteLine(cars[1]);
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            //20.foreach loops
            foreach (string car1 in cars)
            {
                Console.WriteLine(car1);
            }

            //21.methods
            Meathod("ok");


            //22.return keyword
            Console.WriteLine(Multiply(2, 3));

            //23.method overloading
            Console.WriteLine(Multiply(2, 3, 4));

            //24.params keyword
            double total = Checkout(1.2, 2, 3, 4, 5);

            //25.exception handing line:185
            //26.conditional operator
            double temperature = 20;
            Console.WriteLine((temperature >= 15) ? "warm" : "cold");

            //27.string interpolation
            Console.WriteLine($"Hello {firstname} {lastname}.");

            //28.multidimensional arrays
            string[,] parking = {{ "a", "b" },{ "c", "d" }};
            Console.WriteLine(parking[0,0]);

            //29.
            Console.ReadKey();

        }
        static void Meathod(string args)
        {
            Console.WriteLine(args);
        }
        static double Multiply(double a, double b)
        {
            return a * b;
        }
        static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }
        static double Checkout(params double[] args)
        {
            double total = 0;
            foreach (double arg in args)
            {
                total += arg;
            }
            return total;
        }
    }
}