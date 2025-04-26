using Raftel.Domain.Abstractions;

namespace InkDesk.Domain.Customers;

public static class CustomerErrors
{
    public static Error NameIsRequired => new("Customer.Name", "Customer name is required.");
}