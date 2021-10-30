namespace Core.Dao
{
    public interface IDao<T>
    {
        bool Exist();

        void Save(T obj);

        T Load();
    }
}
