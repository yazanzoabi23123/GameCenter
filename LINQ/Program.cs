using System.Linq;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>(12,224,2322,43432343,43423);
            // List<int> list2 = list.Where(number => number >= 100 && number <=1000).ToList();

            // foreach (int x in list2)
            // {
            //     Console.WriteLine(x);
            // }


            //List<string> list = new List<string>("JDNCWEFOWERN");
            //List<string> list2 = list.Select(str => str.ToLower().ToList()

            //string[] result = strList.Where(name => name.Length > 3).Select(name => name.ToUpper()).OrderBy(name => name).ToArray();

            /////////////////////////////////////////////////////// OOP WITH LIST
            //    List<Student> students = new List<Student>
            //    {
            //    new Student { Id = 1, Name = "John", Grade = 70 },
            //    new Student { Id = 2, Name = "Jane", Grade = 40 },
            //    new Student { Id = 3, Name = "Sam", Grade = 55 }
            //    };

            //    IEnumerable<string> failedStudents = students.Where(s => s.Grade < 50).Select(s => s.Name);
            //    Console.WriteLine("Students who didn't pass: " + string.Join(", ", failedStudents));

            //    Student topStudent = students.OrderByDescending(s => s.Grade).FirstOrDefault();
            //    if (topStudent != null)
            //    {
            //        Console.WriteLine($"Student with the highest grade: {topStudent.Name}, Grade: {topStudent.Grade}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No students found.");
            //    }

            //    IEnumerable<string> orderedByName = students.OrderBy(s => s.Name).Select(s => s.Name);
            //    Console.WriteLine("Students in
            //    alphabetical order: " + string.Join(", ", orderedByName));
            //}

            List<Book> books = new List<Book>
            {
                new Book { ISBN = "221323123", Title = "Harry Potter", Author = "Mike", Price= 80},
                new Book { ISBN = "4534543", Title = "Little women", Author = "Alex", Price= 80},
                new Book { ISBN = "3453245", Title = "Maureen Child", Author = "Ryan", Price= 80}

            };
            IEnumerable<string> specificauthor = books.Where(book => book.Author == "Author1").Select(book =>book.Title);
            Console.WriteLine("books wrtiten by the Author: " + string.Join(", ", specificauthor));

            double avgPrice = books.Average(b => b.Price);
            Console.WriteLine($"Average Book Price: {avgPrice}");


            IEnumerable<string> orderedByPrice = books.OrderByDescending(book => book.Price).Select(book => $"{book.Title}:{book.Price}");
        }
    }
}
