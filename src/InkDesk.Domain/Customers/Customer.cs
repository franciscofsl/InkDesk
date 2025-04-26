using InkDesk.Domain.Customers.ValueObjects;
using Raftel.Domain.BaseTypes;

namespace InkDesk.Domain.Customers;

public class Customer : AggregateRoot<CustomerId>
{
    private Customer() : base()
    {
    }

    private Customer(Name name) : base(CustomerId.New())
    {
        Name = name;
    }

    public Name Name { get; private set; }

    public static Customer Create(Name name)
    {
        return new Customer(name);
    }
}