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
        _view.displayMovies();
    }
}