using AnotherAssembly;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AssemblyLoadMinimalReproductionFunctionApp
{
    public class DependencyInjector : IDependencyInjector
    {
        public void Register(IServiceCollection services, IConfiguration configuration)
        {
            throw new System.NotImplementedException();
        }
    }
}
