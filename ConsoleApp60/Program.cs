namespace ConsoleApp60
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number;
            int numberStartExample = 0;
            int stepDivisionInExample = 3;
            int stepDivisionInExample2 = 5;
            int randomNumberMinimum = 0;
            int randomNumberMaximum = 101;
            float result;
            float result2;
            float finalResult = 0;
            number = random.Next(randomNumberMinimum, randomNumberMaximum);

            Console.WriteLine("Ваше число:" + number);

            if (number % stepDivisionInExample == 0)
            {
                result = number;
                finalResult += result;
            }
            
            if (number % stepDivisionInExample2 == 0)
            {
                result2 = number;
                finalResult += result2;
            }
         
            finalResult += number;

            Console.WriteLine("Общая сумма, кратных - " + stepDivisionInExample + " и " + stepDivisionInExample2 + ", равна - " + finalResult);
        }
    }
}