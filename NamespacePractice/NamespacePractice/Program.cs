using static System.Console;


namespace ProjectA
{
    namespace TeamA
    {
        class A
        {
            public static void PrintA()
            {
                WriteLine("Team A Print method");
            }
        }
    }

    namespace TeamB
    {
        class A
        {
            public static void PrintA()
            {
                WriteLine("Team B Print method");
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World!");
            TeamA.A.PrintA();
            TeamB.A.PrintA();


        }

    }
}