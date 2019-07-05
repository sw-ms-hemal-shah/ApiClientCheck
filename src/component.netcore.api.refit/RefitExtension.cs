using component.netcore.api.refit.interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace component.netcore.api.refit
{
    /// <summary>
    /// Resolves dependency for this library
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static class RefitExtension
    {
        /// <summary>
        /// AddAccess
        /// </summary>
        public static IServiceCollection AddRefit(this IServiceCollection services)
        {
            services.AddTransient<IApiCaller, ApiCaller>();
            return services;
        }
    }
}
