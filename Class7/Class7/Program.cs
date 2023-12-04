namespace Class7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> userItems = new List<string>();
            //string choice;
            //do
            //{
            //    Console.WriteLine("Please choose an option:");
            //    Console.WriteLine("1. Add an item");
            //    Console.WriteLine("2. Remove an item");
            //    Console.WriteLine("3. View all items");
            //    Console.WriteLine("4. Exit");
            //    Console.Write("Your choice: ");
            //    choice = Console.ReadLine();

            //    switch (choice)
            //    {
            //        case "1":
            //            //get the item data from the user (ReadLine)
            //            string newItem = Console.ReadLine();
            //            //add the item to the list
            //            userItems.Add(newItem);
            //            //show success message
            //            Console.WriteLine($"'{newItem}' has been added successfully");
            //            break;
            //        case "2":
            //            //get the item to remove
            //            string itemToRemove = Console.ReadLine();
            //            //remove this item
            //            userItems.Remove(itemToRemove);
            //            //message
            //            Console.WriteLine($"'{itemToRemove}' has been removed successfully");
            //            break;
            //        case "3":
            //            //loop on the list of the items and print
            //            for (int i = 1; i <= userItems.Count; i++)
            //            {
            //                Console.WriteLine($"Item {i}. {userItems[i - 1]}");
            //            }
            //            break;
            //        case "4":
            //            //message - exiting..
            //            Console.WriteLine("Exiting the program..");
            //            break;
            //        default: //message - invalide input
            //            Console.WriteLine("Invalid input, insert another choice");

            //            break;
            //    }
            //} while (choice != "4");

            var library = new MovieLibrary();
            var newMovie = new Movie(1, "The Shawshank Redemption", "Frank Darabont", 1994);
            library.AddMovie(newMovie);

            // Editing a movie
            Console.WriteLine("Which movie do you want to edit? Enter the ID:");
            var idToEdit = int.Parse(Console.ReadLine());
            library.EditMovie(idToEdit);

            // Deleting a movie by ID
            Console.WriteLine("Enter the ID of the movie you want to delete:");
            var idToDelete = int.Parse(Console.ReadLine());
            library.DeleteMovieById(idToDelete);

            // Deleting a movie according to "the letter with which its title begins"
            Console.WriteLine("Enter the letter with which the title of the movies you want to delete starts:");
            var letterToDelete = Console.ReadLine();
            library.DeleteMoviesByTitleStartingWith(letterToDelete);
        }
    }
    

}