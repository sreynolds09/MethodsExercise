namespace MethodsExercise
{
    public class Program
    {
        public static void StoryTime()
        {
            Console.WriteLine("What is your name?");
            String userName = Console.ReadLine();
            Console.WriteLine("Where would you most like to go?");
            String mostWantedVisit = Console.ReadLine();
            Console.WriteLine("Who is your favorite person?");
            String favoritePerson = Console.ReadLine();
            Console.WriteLine("What are three wishes that you would ask of a genie?");
            String wishList = Console.ReadLine();
            Console.WriteLine(
                $"One day, {userName} went to visit {mostWantedVisit} with their favorite person in the world, {favoritePerson}. While exploring, they stumbled upon an ancient looking lamp. {favoritePerson} suggested a closer look and a genie popped out! I am the genie of CSharp-56 what are your three wishes. After some thought you and {favoritePerson} ask for {wishList}. After some thought, the genie decides to grant all wished. The End.");
        }

        public static int Add(int a, int b)
        {
            return (a + b);
        }

        public static int Subtract(int c, int d)
        {
            return (c - d);
        }

        public static int Multiply(int e, int f)
        {
            return (e * f);
        }

        public static int Divide(int g, int h)
        {
            return (g / h);
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum = sum + number;

            }
            return sum;
        }

        static void Main(string[] args)
            {
                StoryTime();
                int addnums = Add(a:2, b:2);
                Console.WriteLine(addnums);
                Console.WriteLine(Add(a: 3, b: 3));
                Console.WriteLine(Subtract(c: 3, d: 3));
                Console.WriteLine(Multiply(e: 3, f: 3));
                Console.WriteLine(Divide(g: 3, h: 3));
                Console.WriteLine (Sum( 5, 5, 5));
            }
        }
    }

