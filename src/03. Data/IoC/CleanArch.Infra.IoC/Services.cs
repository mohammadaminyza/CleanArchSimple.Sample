using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infra.IoC;

public static class Services
{
    public static void AddIoC(this IServiceCollection services)
    {
        #region Repositories
        //services.AddScoped<IRepository>();
        #endregion

        #region ApplicationService
        #endregion
    }
}