namespace OOP2_Matrix_Class
{
    internal class program
    {
        static void Main(string[] args)
        {
            double[,] a = { { 1, 2, 3 },
                            { 4, 5, 6}};
            double[,] b = { {2,3 },
                            {2,3 },
                            {2,3 }};
            Matrix m1 = new Matrix(a);
            Matrix m2 = new Matrix(b);
            Matrix result = m2 * m1;
            Console.WriteLine(result);
        }
    }
}