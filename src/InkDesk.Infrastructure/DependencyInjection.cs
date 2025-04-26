using InkDesk.Domain.Customers;
using InkDesk.Infrastructure.Data;
using InkDesk.Infrastructure.Data.Customers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Raftel.Infrastructure;

namespace InkDesk.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddRaftelData<InkDeskDbContext>(configuration);
        services.AddScoped<ICustomersRepository, CustomersRepository>();
        return services;
    }
}