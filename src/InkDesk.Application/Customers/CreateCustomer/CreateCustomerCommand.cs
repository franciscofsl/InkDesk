using Raftel.Application.Commands;

namespace InkDesk.Application.Customers.CreateCustomer;
public sealed record CreateCustomerCommand(string Name) : ICommand;