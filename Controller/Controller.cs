public class Controller
{
    private Movie _model;
    private View _view;

    public Controller(Movie model, View view)
    {
        _model = model;
        _view = view;
    }

    public void AddMovie(string title, int year, string genre, string developer)
    {
        _model.AddMovie(title, year, genre, developer);
        Console.WriteLine("Movie has been added successfully!");
    }

    public void Run()
    {
        bool isRunning = true;
        
        while (isRunning)
        {
            Console.WriteLine("Welcome to Movie Manager");
            Console.WriteLine("1. Add a movie");
            Console.WriteLine("2. View all movies");
            Console.WriteLine("3. Exit program");
            Console.Write("\nChoose an alternative, 1-3: \n");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("\nWrite movie title: ");
                    string title = Console.ReadLine() ?? string.Empty;

                    Console.Write("Write movie year: ");
                    int year = int.Parse(Console.ReadLine() ?? "0");

                    Console.Write("Write movie genre: ");
                    string genre = Console.ReadLine() ?? string.Empty;

                    Console.Write("Write movie director: ");
                    string developer = Console.ReadLine() ?? string.Empty;

                    AddMovie(title, year, genre, developer);
                    break;
                case "2":
                    _view.displayMovies();
                    break;
                
                case "3":
                    isRunning = false;
                    Console.WriteLine("\nExiting program..\n");
                    break;
                
                default:
                    Console.WriteLine("\nInvalid choice, try again\n");
                    break;
            }
        }
    }
}