namespace isEqual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Massiv ichida berilgan son bor
                //yo’qligini aniqlaydigan dastur tuzing.

                Console.Write("Enter row length=> ");
                int.TryParse(Console.ReadLine(), out int row);

                FillArray(ref row);
            }
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

            Console.Write("Enter K number=> ");
            int.TryParse(Console.ReadLine(), out int isEqual);

            for (int i = 0; i < row; i++)
            {
                if (array[i] == isEqual)
                {
                    isEqual = array[i];
                    Console.WriteLine($" {isEqual}! Does exist in the array=> {isEqual}");
                }
                else
                {
                    array[i] = array[i];
                    Console.WriteLine($" {isEqual}! Does not exist in the array=> {array[i]}");
                }
            }
            Console.WriteLine();
        }
    }
}