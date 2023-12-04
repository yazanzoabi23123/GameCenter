using System.Diagnostics;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task<string> data = LoadDataAsync();

            //Print5();

            //Console.WriteLine(data.Result);

            List<string> images = new List<string> { "building.jpg","house.jpg","dog.jpg"};

            List<Task> tasks = new List<Task>();

            foreach (var image in images)
            {

                tasks.Add(ApplyFilterAsync(image));

            }

            Task.WhenAll(tasks).Wait();


            int result = CalculateAsync(2).ContinueWith(n => n.Result + 10).Result;

            Console.WriteLine(result);


            // Example list of numbers. Replace this with your actual list.
            var numbers = Enumerable.Range(1, 10000000).ToList();

            // Serial execution
            var stopwatchSerial = Stopwatch.StartNew();
            var primeNumbersSerial = numbers.Where(IsPrime).ToList();
            stopwatchSerial.Stop();

            // Parallel execution
            var stopwatchParallel = Stopwatch.StartNew();
            var primeNumbersParallel = numbers.AsParallel().Where(IsPrime).ToList();
            stopwatchParallel.Stop();

            // Results
            //Console.WriteLine("Serial Prime Numbers: " + string.Join(", ", primeNumbersSerial));
            Console.WriteLine("Serial Execution Time: " + stopwatchSerial.ElapsedMilliseconds + " ms");

            //Console.WriteLine("Parallel Prime Numbers: " + string.Join(", ", primeNumbersParallel));
            Console.WriteLine("Parallel Execution Time: " + stopwatchParallel.ElapsedMilliseconds + " ms");
        }

        private static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }



        static async Task<string> LoadDataAsync()
        {

            Console.WriteLine("Starting data load");

            await Task.Delay(8000);

            return "Data loaded successfully";

        }

        static async Task Print5()
        {

            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine("Doing other work " + i);

                await Task.Delay(1000);

            }

        }
        static async Task ApplyFilterAsync(string image)
        {

            Console.WriteLine("Start filtering " + image);

            await Task.Delay(500 * image.Length);

            Console.WriteLine("Finish filtering " + image);
        }

        static async Task<int> CalculateAsync(int number)
        {

        await Task.Delay(1000);

        return number * 2;

        }
}