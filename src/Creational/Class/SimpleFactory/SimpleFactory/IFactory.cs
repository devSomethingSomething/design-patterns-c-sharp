namespace SimpleFactory
{
    public interface IFactory<T>
    {
        T Create(string type);
    }
}
