using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace component.netcore.api.refit.interfaces
{
    public interface IDynamicRefit<T, in TKey> where T : class
    {
        [Get("")]
        Task<T> Get();

        [Get("")]
        Task<T> Get(Dictionary<string, object> parameters);

        [Post("")]
        Task<T> Post([Body] TKey payload);

        [Post("")]
        Task<T> Post([Header("Content-Type")]string type, [Body(BodySerializationMethod.Default)] string payload);

        [Post("")]
        Task<T> Post();

        [Put("")]
        Task<T> Put([Body]TKey payload);

        [Delete("")]
        Task<T> Delete();
    }
}
