using System.Diagnostics;

namespace Concurrency
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Stopwatch sw = Stopwatch.StartNew();

            //download5Files("myFile");

            //Console.WriteLine("sequence runing time: " + sw.ElapsedMilliseconds + "ms");

            //sw.Restart();

            //download5FilesConcurrently("myFile");

            //Console.WriteLine("concurrent runing time: " + sw.ElapsedMilliseconds + "ms");

            Stopwatch sw = Stopwatch.StartNew();
            sendNReqSequence("google.com", 3);
            Console.WriteLine("sequence runing time: " + sw.ElapsedMilliseconds + "ms");
            sw.Restart();
            sendNReqParallel("google.com", 5);
            Console.WriteLine("concurrent runing time: " + sw.ElapsedMilliseconds + "ms");

        }
        static void downloadFile(string path)
        {

            Console.WriteLine("Start downloading " + path);

            Thread.Sleep(1000);

            Console.WriteLine(path + " has been download");

        }
        static void download5Files(string fileName)
        {

            //loop file1,2,3,4,5

            for (int i = 1; i <= 5; i++)

            {

                //use downloadFile

                downloadFile(fileName + i);

            }

        }
        static void download5FilesConcurrently(string fileName)
        {

            Thread[] threads = new Thread[5];

            for (int i = 0; i < 5; i++)
            {

                int j = i + 1;

                threads[i] = new Thread(() => downloadFile(fileName + j));

                threads[i].Start();

            }

            foreach (var thread in threads)
            {

                thread.Join();

            }

        }

        static void sendNReqSequence(string url, int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Sending get request" + i + " to " + url);
                Thread.Sleep(1000);
                Console.WriteLine("we get response " + i);
            }

        }

        static void sendNReqParallel(string url, int n)
        {
            Thread[] threads = new Thread[n];
            for (int i = 0; i < n; i++)
            {
                threads[i] = new Thread(() =>
                {
                    int index = i + 1;
                    Console.WriteLine("Sending get request" + index + " to " + url);
                    Thread.Sleep(1000);
                    Console.WriteLine("we get response " + index);
                });
                threads[i].Start();
            }
            foreach (var thread in threads)
            {
                thread.Join();
            }
        }
       /// <summary>
       /// /////////////////////////////////////////////////////////////////////////////////////
       /// </summary>
       /// <param name="data"></param>
       /// <param name="n"></param>
       /// <returns></returns>
        static Dictionary<string, int> NgramsFreq(string data, int n)
        {

            Dictionary<string, int> freq = new Dictionary<string, int>();

            string[] words = data.Split(new[] { ' ', '\n', '\t', '\r' });

            for (int i = 0; i < words.Length - n + 1; i++)
            {

                //string[] term = words.Skip(i).Take(n).ToArray();

                string gram = string.Join(" ", words, i, n);

                if (freq.ContainsKey(gram))
                {
                    freq[gram]++;
                }

                else
                {
                    freq[gram] = 1;
                }

            }

            return freq;
        }

        static void printDict(Dictionary<string, int> dict)
        {

            foreach (var item in dict)
            {

                Console.WriteLine(item.Key + " : " + item.Value);
            }

        }
    }
}