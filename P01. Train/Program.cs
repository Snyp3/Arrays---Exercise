namespace P01._Train

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagonsCount = int.Parse(Console.ReadLine());
            int[] wagons = new int[wagonsCount];

            for (int i = 0; i < wagonsCount; i++) // for (int i = 0; i < wagons.Length; i++)
            {
                int passengers = int.Parse(Console.ReadLine());
                wagons[i] = passengers;

            }
            Console.WriteLine(string.Join(" ",wagons)); // Събира ги с место жеду тях
            Console.WriteLine(wagons.Sum()); // спестява това по надолу -->

          // int total = 0;
          //
          // for (int i = 0; i <wagons.Length; i++)
          // {
          //     total += wagons[i];
          // }
          // Console.WriteLine(total);
        }
    }
}