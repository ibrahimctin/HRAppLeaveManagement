using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace HRAppLeaveManagement.Application
{
    public static class ApplicationServicesRegistration
    {

        public static IServiceCollection ConfigureApplicationServicesRegistration(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
