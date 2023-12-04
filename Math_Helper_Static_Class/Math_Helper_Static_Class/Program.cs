namespace Math_Helper_Static_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, 4, 5, 4, 2 };
            foreach (int i in MathHelper.BubbleSort(n)) {
                Console.WriteLine(i);

            }


        }
    }
}


