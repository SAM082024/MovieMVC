public class Controller
{
    private Movie _model;
    private View _view;

    public Controller(Movie model, View view)
    {
        _model = model;
        _view = view;
    }

    public void Run()
    {
        _view.displayMovies();
    }
}