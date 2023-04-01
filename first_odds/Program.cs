namespace first_odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                //1.n natural soni berilgan.Dastlabki n ta toq sondan
                //tashkil topgan massiv hosil qiladigan dastur tuzing.

                Console.Write("Enter number N=> ");
                int number = Convert.ToInt32(Console.ReadLine());
                Random random = new Random();
                random.Next(number);

                Console.WriteLine($"Dastlabki {number} ta toq son massivi: ");
                for (int i = 1; i < number * 2; i++)
                {
                    if (i % 2 != 0)  Console.Write(i + " ");
                }
                    Console.WriteLine();
            }
        }
    }
}