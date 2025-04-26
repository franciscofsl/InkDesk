using InkDesk.Domain.Customers;
using Raftel.Application.Commands;
using Raftel.Domain.Abstractions;

namespace InkDesk.Application.Customers.CreateCustomer;

internal sealed class CreateCustomerCommandHandler(ICustomersRepository repository)
    : ICommandHandler<CreateCustomerCommand>
{
    public async Task<Result> HandleAsync(CreateCustomerCommand request, CancellationToken token = default)
    {
        var customer = Customer.Create(request.Name);
        await repository.AddAsync(customer, token);
        return Result.Success();
    }
}