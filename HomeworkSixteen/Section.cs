namespace HomeworkSixteen
{
    public static class Section
    {
        public static void Welcome()
        {
            Console.WriteLine("Homework Sixteen");
            Console.WriteLine("----------------");
            Console.WriteLine();
        }

        public static void Core()
        {
            int option = Process.GetOption();
            double x = Process.GetNumber("Enter first number: ");
            double y = Process.GetNumber("Enter second number: ");
            double result = Process.GetResult(option, x, y);

            Process.ShowResult(option, x, y, result);
        }

        public static void End()
        {
            Console.WriteLine();
            Console.WriteLine("End of program.");
            Console.ReadLine();
        }
    }
}
