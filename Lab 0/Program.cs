namespace Lab_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Console.WriteLine("Enter a low number:");
            int lowNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a high number: ");
            int highNumber = int.Parse(Console.ReadLine());

            int difference = lowNumber - highNumber;

            Console.WriteLine($"The difference between {highNumber} and {lowNumber} is {difference}");
            // Task 2
            do
            {
                Console.WriteLine("Enter a positive low number: ");
                lowNumber = int.Parse(Console.ReadLine());
            }
            while (lowNumber <= 0);
            Console.WriteLine($"You entered a positive low number: {lowNumber}");

            do
            {
                Console.WriteLine("Enter a high number greater than the low number: ");
                highNumber = int.Parse(Console.ReadLine());
            } while (highNumber <= lowNumber);
            
            Console.WriteLine($"You entered a high number greater than the low number: {highNumber}.");
            //Task 3
            int[] numbers = new int[highNumber - lowNumber + 1];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = lowNumber + i;
            }

            Console.WriteLine("Numbers in reverse order");

        }
    }
}
