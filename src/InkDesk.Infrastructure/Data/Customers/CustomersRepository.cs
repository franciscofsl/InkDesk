using InkDesk.Domain.Customers;
using InkDesk.Domain.Customers.ValueObjects;
using Raftel.Infrastructure.Data;

namespace InkDesk.Infrastructure.Data.Customers;

public class CustomersRepository(InkDeskDbContext dbContext)
    : EfRepository<InkDeskDbContext, Customer, CustomerId>(dbContext), ICustomersRepository
{
}