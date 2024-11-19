namespace Application.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string type, string identifier) : base($"Entity type of {type} not found with identifie: {identifier}") { }
    }
}