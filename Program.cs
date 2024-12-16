namespace ConsoleApp55
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomMinNumber = 1;
            int randomMaxNumber = 100;
            int degree = 1;
            int baseOfDegree = 2;
            int finalNumber = 1;

            Random random = new Random();
            int number = random.Next(randomMinNumber, randomMaxNumber);

            Console.WriteLine("Случайное число - " + number);

            int currentNumber;

            for (currentNumber = baseOfDegree; currentNumber <= number; currentNumber *= baseOfDegree)
            {
                degree++;
            }

            Console.WriteLine("Нужная степень двойки - " + degree + " \nЧисло два в найденной степени - " + currentNumber * finalNumber);
        }
    }
}
