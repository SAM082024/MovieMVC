using System.Dynamic;

public class Model
{
    public string? Title { get; set; } // For displaying the title of the movie
    public int Year { get; set; } // For displaying the release year of the movie
    public string? Genre { get; set; } // For displaying the movie genre
    public string? Director { get; set; } // For displaying the movie director
}

public class Movie
{
    public List<Model> Movies { get; set; }

    public Movie()
    {
        Movies = new List<Model>
        {
            new() { Title = "Prometheus", Year = 2012, Genre = "Sci-Fi, Horror, Action, Thriller", Director = "Ridley Scott"},
            new() { Title = "Alien Covenant", Year = 2017, Genre = "Sci-Fi, Horror, Action, Thriller", Director = "Ridley Scott"},
            new() { Title = "Alien", Year = 1979, Genre = "Sci-Fi, Horror, Action, Thriller", Director = "Ridley Scott"},
            new() { Title = "Alien", Year = 1986, Genre = "Sci-Fi, Horror, Action, Thriller", Director = "James Cameron"},
            new() { Title = "Alien 3", Year = 1992, Genre = "Sci-Fi, Horror, Action, Thriller", Director = "David Fincher"},
        };
    }
}