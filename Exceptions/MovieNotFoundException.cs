namespace MovieArchive.Exceptions
{
    public class MovieNotFoundException : Exception
    {
        public MovieNotFoundException(int id)
            : base($"Movie with ID {id} was not found.") { }
    }
}