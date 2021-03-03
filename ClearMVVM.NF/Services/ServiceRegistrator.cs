using ClearMVVM.NF.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ClearMVVM.NF.Services
{
    internal static class ServiceRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
            .AddTransient<IDataService, DataService>()
            .AddTransient<IUserDialog, UserDialogService>();
    }
}
