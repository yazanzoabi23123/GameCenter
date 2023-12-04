namespace LINQ_OOP
{
    
    internal class Program
    {
       static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Alice", Grade = 90 },
            new Student { Id = 2, Name = "Bob", Grade = 85 },
            new Student { Id = 3, Name = "Charlie", Grade = 78 },
            new Student { Id = 4, Name = "David", Grade = 93 },
            new Student { Id = 5, Name = "Eve", Grade = 88 },
            new Student { Id = 6, Name = "Frank", Grade = 76 },
            new Student { Id = 7, Name = "Grace", Grade = 89 },
            new Student { Id = 8, Name = "Hannah", Grade = 92 },
            new Student { Id = 9, Name = "Ian", Grade = 75 },
            new Student { Id = 10, Name = "Jane", Grade = 91 },
        };

        static List<Person> people = new List<Person>
        {
            new Person { Name = "Aline",Age=25},
             new Person {  Name = "Bob", Age = 85 },
            new Person { Name = "Charlie", Age = 78 },
            new Person {  Name = "David", Age = 93 },
            new Person { Name = "Eve", Age = 88 },
            new Person {  Name = "Frank", Age = 76 },
            new Person {  Name = "Grace", Age = 89 },
            new Person {  Name = "Hannah", Age = 92 },
            new Person {Name = "Ian", Age = 75 },
            new Person {  Name = "Jane", Age = 91 },
        };

       static  List<Book> books = new List<Book>
        {
                new Book { ISBN = "221323123", Title = "Harry Potter", Author = "Mike", Price= 80},
                new Book { ISBN = "4534543", Title = "Little women", Author = "Alex", Price= 80},
                new Book { ISBN = "3453245", Title = "Maureen Child", Author = "Ryan", Price= 80}

        };
        static public List<Customer> customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "John Doe" },
            new Customer { Id = 2, Name = "Jane Smith" },
            new Customer { Id = 3, Name = "Emily Johnson" },
            new Customer { Id = 4, Name = "Michael Brown" }
        };
        static List<Order> orders = new List<Order>
         {
             new Order { Id = 1, CustomerId = 1, Price = 100.50 },
             new Order { Id = 2, CustomerId = 1, Price = 200.75 },
             new Order { Id = 3, CustomerId = 1, Price = 50.25 },
             new Order { Id = 4,CustomerId = 1, Price = 300.40 },
             new Order { Id = 5,CustomerId = 1, Price = 150.00 },
             new Order { Id = 6,CustomerId = 1, Price = 250.80 },
             new Order { Id = 7,CustomerId = 2, Price = 80.00 },
             new Order { Id = 8,CustomerId = 2, Price = 120.00 },
             new Order {Id = 9, CustomerId = 3, Price = 90.00 },
             new Order { Id = 10,CustomerId = 3, Price = 210.00 },
             new Order { Id = 11,CustomerId = 4, Price = 500.00 },
             new Order { Id = 12,CustomerId = 4, Price = 60.00 },
             new Order { Id = 13,CustomerId = 4, Price = 140.00 },
             new Order { Id = 14,CustomerId = 4, Price = 80.00 }
      };
        static void Main(string[] args)
        {
            //var peopleAbove21 = people.Where(p => p.Age > 21);
            //var agesdGroups = people.GroupBy(p => (p.Age / 10) * 10);

            //foreach (var item in agesdGroups)
            //{
            //    Console.WriteLine(item.Key+"+");
            //    foreach (var person in item)
            //    {
            //        Console.WriteLine(person.Name+"  "); 
            //    }
            //    Console.WriteLine();
            //}

            //var SumOfDigits = books.GroupBy(p =>
            //{
            //    int temp = p.Price;
            //    int sum = 0;

            //    while (temp > 0)
            //    {
            //        temp /= 10;
            //        sum += temp;
            //    }
            //    return sum;
            //});


            var customersMore3Orders = customers.Where(c => orders.Where(o => o.CustomerId == c.Id).Count() > 3);

            foreach (var item in customersMore3Orders)
            {
                Console.WriteLine(item.Name);
            }

            var orderJoinCustomer = customers.Join(orders,
                c => c.Id,
                o => o.CustomerId,
                (c, o) => new { name = c.Name, o.Price, CustomerId = c.Id });

            var sumOrdersPerCustomer = orderJoinCustomer.GroupBy(o => o.CustomerId)
                .Select(g => new {
                    customerId = g.Key,
                    sumOfOrdersPrices = g.Sum(order => order.Price),
                    name = g.Select(order => order.name).First()
                });

            foreach (var item in sumOrdersPerCustomer)
            {
                Console.WriteLine(item.name + " : " + item.sumOfOrdersPrices);
            }
        }
    }
}