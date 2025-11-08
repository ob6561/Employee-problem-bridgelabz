namespace Employee_problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            Random rd = new Random();
            int empcheck = rd.Next(0, 2);
            if(empcheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
