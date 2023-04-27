namespace HomeworkSixteen
{
    public static class Process
    {
        public static void InvalidInputMessage()
        {
            Console.WriteLine("Invalid input. Try again.");
        }

        public static int GetOption()
        {
            int output = 0;
            bool runAgain = true;

            while (runAgain)
            {
                Console.Write("Enter desired operation (1) Add (2) Subtract (3) Multiply (4) Divide: ");
                bool rightInput = int.TryParse(Console.ReadLine(), out output);
                bool rightRange = (output > 0) && (output < 5);

                runAgain = (rightInput == false) || (rightRange == false);

                if (runAgain)
                {
                    InvalidInputMessage();
                }
            }

            return output;
        }

        public static double GetNumber(string message)
        {
            double output = 0;
            bool runAgain = true;

            while (runAgain)
            {
                Console.Write(message);
                bool validInput = double.TryParse(Console.ReadLine(), out output);

                runAgain = (validInput == false);

                if (validInput == false)
                {
                    InvalidInputMessage();
                }
            }

            return output;
        }

        public static double GetResult(int option, double x, double y)
        {
            double output = 0;

            switch (option)
            {
                case 1:
                    output = Calculate.Add(x, y);
                    break;
                case 2:
                    output = Calculate.Subtract(x, y);
                    break;
                case 3:
                    output = Calculate.Multiply(x, y);
                    break;
                case 4:
                    output = Calculate.Divide(x, y);
                    break;
                default:
                    break;
            }

            return output;
        }
        
        public static void ShowResult(int option, double x, double y, double result)
        {
            string chosenOperator = Calculate.GetOperator(option);

            Console.WriteLine($"{x} {chosenOperator} {y} = {result}");
        }
    }
}
