namespace InterestCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Interest Calculator");

            String continueChoice;
            do
            {

                //prompt loan 
                Console.Write("Enter loan amount: ");
                decimal loan = decimal.Parse(Console.ReadLine());

                //prompt rate
                Console.Write("Enter interest rate: ");
                decimal intRate = decimal.Parse(Console.ReadLine());

                //define interest
                decimal interest = loan * intRate;

                //format
                string formattedLoan = loan.ToString("C2");
                string formattedInterest = interest.ToString("C2");
                //string formattedIntRate = intRate.ToString("0.##") + "%";
                string formattedIntRate = intRate.ToString("P3");

                Console.WriteLine($"Loan amount: {formattedLoan}");
                Console.WriteLine($"Interest rate: {formattedIntRate}");
                Console.WriteLine($"Loan interest: {formattedInterest}");

                Console.Write("Would you like to continue? (y/n): ");
                continueChoice = Console.ReadLine().ToLower().Trim();
            }while(continueChoice == "y");
        }
    }
}
