using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace P04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = int.Parse(Console.ReadLine());

            int[] inputPlusN = input;

            for (int j = 0; j < n; j++)
            {
                int temp = input[0];

                for (int i = 0; i < input.Length - 1; i++)
                {
                    input[i] = input[i + 1];

                }
                input[input.Length - 1] = temp;

            }
            Console.WriteLine(string.Join(" ", inputPlusN));
        }
    }
}