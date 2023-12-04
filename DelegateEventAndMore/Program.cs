using System.Threading;

namespace DelegateEventAndMore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleStack<int> s = new SimpleStack<int>();
            s.push(10);
            s.push(11);
            s.push(12);
            s.push(13);
            s.push(14);

            SimpleStack<int> s2 =new SimpleStack<int>();
            Clone(s,s2);
            Console.WriteLine(GetK(s, 5));
            Console.WriteLine("-------------------");
            Console.WriteLine(s);
        }
        static T GetK<T>(SimpleStack<T> stack, int k) //k=1 is the first value in the stack
        {
            if (k > stack.Count || k <= 0)
            {
                throw new IndexOutOfRangeException();
            }
            SimpleStack<T> temp = new SimpleStack<T>();
            for (int i = 1; i < k; i++)
            {
                temp.push(stack.pop());
            }
            T item = stack.peak();
            for (int i = 1; i < k; i++)
            {
                stack.push(temp.pop());
            }
            return item;
        }

        static void Clone<T>(SimpleStack<T> s1, SimpleStack<T> s2)
        {
            SimpleStack<T> temp = new SimpleStack<T>();
            while (true)
            {
                try
                {
                    temp.push(s1.pop());
                }
                catch
                {
                    break;
                }
            }
            while (true)
            {
                try
                {
                    T item = temp.pop();
                    s1.push(item);
                    s2.push(item);
                }
                catch
                {
                    break;
                }
            }

        }

    }
}