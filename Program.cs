namespace MovieMVC;

class Program
{
    static void Main(string[] args)
    {
        Movie model = new Movie();
        View view = new View(model);
        Controller controller = new Controller(model, view);

        controller.Run();
    }
}
