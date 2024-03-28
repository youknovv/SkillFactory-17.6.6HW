using Module17.Practice;

namespace Module17
{
    public class Program
    {
        static void Main(string[] args)
        {
            var regularAccount = new RegularAccount
            {
                Balance = 1000
            };
            var salaryAccount = new SalaryAccount()
            {
                Balance = 1000
            };
            
            regularAccount.CalculateInterest();
            salaryAccount.CalculateInterest();

            Console.WriteLine($"Обычная ставка - {regularAccount.Interest}");
            Console.WriteLine($"Cтавка зарплатного аккаунта - {salaryAccount.Interest}");
        }

        private static void Average(string period, int temperature)
        {
            Console.WriteLine($"Welcome to the {period} forecast page");
            Console.WriteLine($"The average temperature expects to be around {temperature} C \r\n");
        }

        public string GetDayOfWeek(int day)
        {
            switch (day)
            {
                case 1:
                    return "Monday";
                case 2:
                    return "Tuesday";
                case 3:
                    return "Wednesday";
                case 4:
                    return "Thursday";
                case 5:
                    return "Friday";
                case 6:
                    return "Saturday";
                case 7:
                    return "Sunday";

                default:
                    throw new InvalidOperationException("День недели должен быть в диапазоне 1 to 7");
            }
        }
    }
}