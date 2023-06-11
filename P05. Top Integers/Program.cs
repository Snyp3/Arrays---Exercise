namespace P05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < input.Length; i++)
            {

               int currentGreaterOne = input[i];

                for (int j = i + 1; j < input.Length; j++)
                {
                    int currentGreaterTwo = input[j];

                    if (currentGreaterOne <= currentGreaterTwo)
                    {
                        break;
                    }
                    else if (j == input.Length - 1)
                    {

                        Console.Write(currentGreaterOne + " ");

                    }

                }
            }
            Console.WriteLine(input[input.Length - 1]);
        }
    }
}