namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var brain = new CalculatorBrain();
            var run = true;
            while (run)
            {
                string result = "";

                ShowMenu();
                var choice = Console.ReadLine();

                if (choice == "Q" || choice == "q")
                {
                    break;
                }

                Console.Write("First value: ");
                int firstValue = GetValidValue();
                Console.Write("Second value: ");
                int secondValue = GetValidValue();
                Console.WriteLine();


                switch (choice)
                {
                    case "1":
                        result = brain.Addition(firstValue, secondValue);
                        break;
                    case "2":
                        result = brain.Subtraction(firstValue, secondValue);
                        break;
                    case "3":
                        result = brain.Multiplication(firstValue, secondValue);
                        break;
                    case "4":
                        result = brain.Division(firstValue, secondValue);
                        break;
                    default:
                        continue;
                }

                Console.WriteLine(result);
                Console.WriteLine();

            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("(1) Addition");
            Console.WriteLine("(2) Subtraction");
            Console.WriteLine("(3) Multiplication");
            Console.WriteLine("(4) Division");
            Console.WriteLine("(Q/q) Quit");
            Console.WriteLine("-----------------");
            Console.Write("Choice: ");
        }

        static int GetValidValue()
        {
            int output;

            while (true)
            {

                var input = Console.ReadLine();

                if (int.TryParse(input, out output))
                {
                    return output;
                }

                Console.Write("Invalid value, try again: ");
            }
        }
    }
}
