using InkDesk.Application.Customers.CreateCustomer;
using Microsoft.AspNetCore.Mvc;
using Raftel.Application.Commands;

namespace InkDesk.Api.Controllers.Customers;

[Route("api/customers")]
[ApiController]
public class CustomerController(ICommandDispatcher commandDispatcher) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateCustomerAsync([FromForm]CreateCustomerRequest request, CancellationToken token)
    {
        var command = new CreateCustomerCommand(request.Name);
        var result = await commandDispatcher.DispatchAsync(command, token);

        if (result.IsFailure)
        {
            return BadRequest(result.Error);
        }

        return Ok(result);
    }
}