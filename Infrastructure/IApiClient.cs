using System.Threading.Tasks;

namespace DemoInteraktiva.Infrastructure
{
    public interface IApiClient
    {
        Task<T> GetAsync<T>(string endpoint);
    }
}
