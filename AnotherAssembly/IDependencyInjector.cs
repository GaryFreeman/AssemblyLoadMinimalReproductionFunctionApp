using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AnotherAssembly
{
    public interface IDependencyInjector
    {
        public void Register(IServiceCollection services, IConfiguration configuration);
    }
}
