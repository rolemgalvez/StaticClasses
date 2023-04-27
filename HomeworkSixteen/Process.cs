namespace HomeworkSixteen
{
    public static class Process
    {
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
                    Console.WriteLine("Invalid input. Try again.");
                }
            }

            return output;
        }

        public static double GetNumber(string message)
        {
            throw new NotImplementedException();
        }

        public static (double result, string chosenOperator) GetResult(int option)
        {
            // get operator
            
            // Do calculate

            throw new NotImplementedException();
        }
        
        public static void ShowResult(double x, double y, string chosenOperator, double result)
        {
            Console.WriteLine($"{x} {chosenOperator} {y} = {result}");
        }
    }
}
