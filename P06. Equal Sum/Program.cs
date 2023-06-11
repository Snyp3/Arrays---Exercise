namespace P06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sumLeft = 0;
            int sumRight = 0;



            for (int i = 0; i < array.Length; i++)
            {
                sumRight += array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                sumRight -= array[i];
                if (sumRight == sumLeft)
                {
                    Console.WriteLine(i);
                    return;
                }
                sumLeft += array[i];
            }

            Console.WriteLine("no");

        }
    }
}