using InkDesk.Domain.Customers.ValueObjects;
using Raftel.Domain.Abstractions;

namespace InkDesk.Domain.Customers;

public interface ICustomersRepository : IRepository<Customer, CustomerId>
{
}