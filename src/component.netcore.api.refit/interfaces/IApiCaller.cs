using component.netcore.api.refit.info;
using System.Threading.Tasks;

namespace component.netcore.api.refit.interfaces
{
    public interface IApiCaller
    {
        Task<T> CallApi<T>(ApiCallInfo apiCallInfo) where T : class;
        Task<T> CallApi<T, U>(ApiCallInfo apiCallInfo) where T : class;
    }
}
