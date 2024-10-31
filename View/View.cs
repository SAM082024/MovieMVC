public class View
{
    private Movie myMovie;

    public View(Movie movie)
    {
        myMovie = movie;
    }

    public void displayMovies()
    {
        Console.WriteLine("Movies in the model:\n");

        foreach (var movie in myMovie.Movies)
        {
            Console.WriteLine($"Title: {movie.Title}\n");
            Console.WriteLine($"Year: {movie.Year}\n");
            Console.WriteLine($"Genre: {movie.Genre}\n");
            Console.WriteLine($"Director: {movie.Director}\n\n\n");
        }
    }
}