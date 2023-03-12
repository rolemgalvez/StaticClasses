namespace HomeworkSixteen
{
    public static class Process
    {
        public static int GetOption()
        {
            throw new NotImplementedException();
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
