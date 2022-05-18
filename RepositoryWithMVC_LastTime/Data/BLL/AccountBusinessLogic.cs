using RepositoryWithMVC_LastTime.Data.DAL;
using RepositoryWithMVC_LastTime.Models;

namespace RepositoryWithMVC_LastTime.Data.BLL
{
    public class AccountBusinessLogic
    {
        IRepository<Account> repo;
        public AccountBusinessLogic(IRepository<Account> repoAry)
        {
            this.repo = repoAry;
        }

        public List<Account> GetAll()
        {
            return repo.GetAll().ToList();
        }

        public double GetBalance(int id)
        {
            Account account = repo.Get(id);
            if(account == null)
            {
                throw new Exception("Account not found");
            }
            else
            {
                return account.Balance;
            }
        }
    }
}
