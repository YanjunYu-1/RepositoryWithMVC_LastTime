using Microsoft.EntityFrameworkCore;
using RepositoryWithMVC_LastTime.Data;

namespace RepositoryWithMVC_LastTime.Models
{
    public class SeedData
    {
        public async static Task Initialize(IServiceProvider serviceProvider)
        {
            var context = new RepositoryWithMVC_LastTimeContext(serviceProvider.GetRequiredService<DbContextOptions<RepositoryWithMVC_LastTimeContext>>());

            if (!context.Customer.Any())
            {
                Customer customer1 = new Customer();
                customer1.Name = "Inky";
                context.Customer.Add(customer1);

                Customer customer2 = new Customer();
                customer2.Name = "Blinky";
                context.Customer.Add(customer2);

                Customer customer3 = new Customer();
                customer3.Name = "Pinky";
                context.Customer.Add(customer3);

                Customer customer4 = new Customer();
                customer4.Name = "Clyd";
                context.Customer.Add(customer4);
            }
            context.SaveChanges();

            if (!context.Account.Any())
            {
                Account account1 = new Account();
                account1.Name = "Checking";
                account1.Balance = 200;
                account1.CustomerId = 1;
                account1.IsActive = true;
                context.Account.Add(account1);

                Account account2 = new Account();
                account2.Name = "Savings";
                account2.Balance = 12;
                account2.CustomerId = 1;
                account2.IsActive = true;
                context.Account.Add(account2);

                Account account3 = new Account();
                account3.Name = "Checking";
                account3.Balance = 321;
                account3.CustomerId = 2;
                account3.IsActive = true;
                context.Account.Add(account3);

                Account account4 = new Account();
                account4.Name = "Savings";
                account4.Balance = -12;
                account4.CustomerId = 2;
                account4.IsActive = true;
                context.Account.Add(account4);

                Account account5 = new Account();
                account5.Name = "Checking";
                account5.Balance = 1245.2;
                account5.CustomerId = 3;
                account5.IsActive = true;
                context.Account.Add(account5);

                Account account6 = new Account();
                account6.Name = "Savings";
                account6.Balance = 324;
                account6.CustomerId = 3;
                account6.IsActive = true;
                context.Account.Add(account6);
            }
            context.SaveChanges();
        }
        

    }
}
