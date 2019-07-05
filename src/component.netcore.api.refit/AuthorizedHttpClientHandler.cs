using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace component.netcore.api.refit
{
    [ExcludeFromCodeCoverage]
    public class AuthorizedHttpClientHandler : HttpClientHandler
    {
        private readonly Dictionary<string, string> _tokenInfo;
        public AuthorizedHttpClientHandler(Dictionary<string, string> tokenInfo)
        {
            _tokenInfo = tokenInfo;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            // See if the request has an authorize header
            if ((_tokenInfo as object) is Dictionary<string, string> dictionaryValues)
            {
                foreach (var (key, value) in dictionaryValues)
                {
                    request.Headers.Add(key, value);
                }
            }
            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }

    }
}
