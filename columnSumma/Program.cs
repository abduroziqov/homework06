namespace columnSumma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 0;
            int col = 0;

            GetNumber(ref row, ref col);
            FillArray(row, col);

            Main(args);
        }

        public static void GetNumber(ref int row, ref int col)
        {
            Console.Write("Enter row value=> ");
            row = int.Parse(Console.ReadLine());

            Console.Write("Enter column value=> ");
            col = int.Parse(Console.ReadLine());
        }
        public static void FillArray(int row, int column)
        {
            Random random = new Random();
            int[,] array = new int[row, column];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    array[i, j] = random.Next(1, 5);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.Write("Enter K number=> ");
            int number = int.Parse(Console.ReadLine());
            int summa = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (j == number - 1)
                    {
                        summa += array[i, j];
                    }
                }

            }
            Console.WriteLine($"Sum of K column is equal to: {summa}");
            Console.WriteLine();
        }
    }
}