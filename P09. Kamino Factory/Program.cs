namespace P09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());


            for (int i = 0; i < length; i++)
            
            {
            string input = Console.ReadLine();
            int[] dnaInput = new int[length];
                dnaInput = input.Trim('!')
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                    

            Console.WriteLine(dnaInput);

            }
            
            
        }
    }
}