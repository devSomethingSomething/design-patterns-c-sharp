namespace SimpleFactory
{
    public interface IFactory
    {
        object Create(string type);
    }
}
