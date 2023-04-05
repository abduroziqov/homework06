namespace check_sign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Berilgan sonning ishorasini
                //aniqlab qaytaruvchi method yarating.

                Console.WriteLine(GetNumberInput());
            }
        }
        public static int GetNumberInput()
        {
            Console.Write("Enter a number: ");
            int.TryParse(Console.ReadLine(), out var number);

            if (number > 0)
            {
                Console.WriteLine($"{number} is big than 0.");
            }
            else if (number == 0)
            {
                Console.WriteLine($"{number} is neither big nor small.");
            }
            else
            {
                Console.WriteLine($"{number} is small than 0.");
            }
            return number;
        }
    }
}