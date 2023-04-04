namespace summa_multi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Berilgan massiv elementlarining yig’indisi
            //va ko’paytmasini topadigan dastur tuzing.

            int row = 0;
            int col = 0;

            GetNumber(ref row, ref col);
            FillArray(row, col);
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
                    array[i, j] = random.Next(10, 100);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            decimal summa = 0, multi = 1;
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    summa += array[i, j];
                    multi *= array[i, j];
                }
            }
            Console.WriteLine($"Summa is equal to: {summa}");
            Console.WriteLine($"Multiplication is equal to: {multi}");
        }
    }
}