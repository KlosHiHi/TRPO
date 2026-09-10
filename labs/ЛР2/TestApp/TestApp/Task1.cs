using System.Text.RegularExpressions;

namespace TestApp
{   
    public static class Task1
    {
        public static decimal Power(double a, int n)
        {
            decimal result = (decimal)Math.Pow(a, n);
            return Math.Round(result, 3);
        }

        public static bool SafePassword(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[/+!@#$%^&*(),.?"":{}|<>]).{8,30}$");
        }
    }
}
