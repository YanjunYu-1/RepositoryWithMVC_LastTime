namespace RepositoryWithMVC_LastTime.Data.DAL
{
    public interface IRepository<T> where T : class
    {
        //Creat
        void Add(T entity);

        //Read
        T Get(int id);
        T Get(Func<T,bool> func);
        ICollection<T> GetAll();
        ICollection<T> GetList(Func<T,bool> func);

        //UpData
        void Updata(T entity);

        //Delete
        void Delete(T entity);

        //Save
        void Save();
    }
}
