using RepositoryWithMVC_LastTime.Models;

namespace RepositoryWithMVC_LastTime.Data.DAL
{
    public class AccountRepository : IRepository<Account>
    {
        public RepositoryWithMVC_LastTimeContext Context { get; set; }
        public AccountRepository(RepositoryWithMVC_LastTimeContext context)
        {
            Context = context;
        }

        public void Add(Account entity)
        {
            Context.Add(entity);
        }

        public void Delete(Account entity)
        {
            Context.Account.Remove(entity);
        }

        public Account Get(int id)
        {
            return Context.Account.First(x => x.Id == id);  
        }

        public Account Get(Func<Account, bool> func)
        {
            return Context.Account.First(func);
        }

        public ICollection<Account> GetAll()
        {
            return Context.Account.ToList();
        }

        public ICollection<Account> GetList(Func<Account, bool> func)
        {
            return Context.Account.Where(func).ToList();
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        public void Updata(Account entity)
        {
            Context.Account.Update(entity);
        }
    }
}
