﻿namespace HomeworkSixteen
{
    public static class Calculate
    {
        public static string GetOperator(int option)
        {
            string output = string.Empty;

            switch (option)
            {
                case 1:
                    output = "+";
                    break;
                case 2:
                    output = "-";
                    break;
                case 3:
                    output = "x";
                    break;
                case 4:
                    output = "÷";
                    break;
                default:
                    break;
            }

            return output;
        }

        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static double Subtract(double x, double y)
        {
            return x - y;
        }

        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        public static double Divide(double x, double y)
        {
            return x / y;
        }
    }
}
