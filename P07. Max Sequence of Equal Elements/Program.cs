namespace P07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] reverseInput = input.Reverse().ToArray();

            int equalCount = 0;
            int biggestEqualCount = 0;
            int currentElement = 0;
            int lastElement = 0;


            for (int i = 0; i < reverseInput.Length; i++)
            {

                currentElement = reverseInput[i];
                if (i == 0 || equalCount == 0)
                {
                    equalCount++;

                }
                
                else if (currentElement == reverseInput[i - 1])
                {
                    equalCount++;

                }

                else
                {
                    equalCount = 1;
                }

                if (biggestEqualCount <= equalCount)
                {
                    biggestEqualCount = equalCount;
                    lastElement = reverseInput[i];
                }

            }
                for (int k = 0; k < biggestEqualCount; k++)
                {
                    Console.Write($"{lastElement} ");

                }


        }
    }
}