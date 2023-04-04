namespace diviser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Berilgan massivning elemntlari orasidan
            //K soniga karrali bo’lganlarini chiqaruvchi dastur tuzilsin.
            Console.Write("Enter row length=> ");
            int.TryParse(Console.ReadLine(), out int row);

            FillArray(ref row);
        }

        public static void FillArray(ref int row)
        {
            Random random = new Random();
            int[] array = new int[row];

            for (int i = 0; i < row; i++)
            {
                array[i] = random.Next(10, 99);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            Console.Write("Enter a diviser=> ");
            int.TryParse(Console.ReadLine(), out int diviser);

            for (int i = 0; i < row; i++)
            {
                if (array[i] % diviser == 0)
                {
                    Console.Write(array[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}