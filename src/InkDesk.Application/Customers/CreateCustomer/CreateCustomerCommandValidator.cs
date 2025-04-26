using InkDesk.Domain.Customers;
using Raftel.Domain.Validators;

namespace InkDesk.Application.Customers.CreateCustomer;

public sealed class CreateCustomerCommandValidator : Validator<CreateCustomerCommand>
{
    public CreateCustomerCommandValidator()
    {
        EnsureThat(_ => !string.IsNullOrEmpty(_.Name), CustomerErrors.NameIsRequired);
    }
}