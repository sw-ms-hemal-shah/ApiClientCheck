using component.netcore.api.refit.info;
using component.netcore.api.refit.interfaces;
using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Threading.Tasks;

namespace component.netcore.api.refit
{
    [ExcludeFromCodeCoverage]
    public class ApiCaller : IApiCaller
    {
        public async Task<T> CallApi<T>(ApiCallInfo apiCallInfo) where T : class
        {
            if(apiCallInfo != null)
            {
                if (string.IsNullOrEmpty(apiCallInfo.StringQueryParamValues) && string.IsNullOrEmpty(apiCallInfo.Headers))
                    return await _defaultApiCall<T>(apiCallInfo);
                else
                    return await _stringParameterApiCall<T>(apiCallInfo);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public async Task<T> CallApi<T,U>(ApiCallInfo apiCallInfo) where T : class
        {
            var service = RestService.For<IDynamicRefit<T, U>>(new HttpClient(new AuthorizedHttpClientHandler(apiCallInfo.HeaderValues)) { BaseAddress = new Uri(apiCallInfo.Url) });

            switch (apiCallInfo.HttpMethod.ToLower())
            {
                case "get":
                    return await service.Get(apiCallInfo.QueryParamValues as Dictionary<string, object>);
                case "post":
                    return await service.Post((U)apiCallInfo.QueryParamValues);
                case "put":
                    return await service.Put((U)apiCallInfo.QueryParamValues);
                default:
                    throw new NotImplementedException();
            }
        }

        #region Private Method
        private async Task<T> _defaultApiCall<T>(ApiCallInfo apiCallInfo) where T : class
        {
            var service = RestService.For<IDynamicRefit<T, string>>(new HttpClient(new AuthorizedHttpClientHandler(apiCallInfo.HeaderValues)) { BaseAddress = new Uri(apiCallInfo.Url) });
            switch (apiCallInfo.HttpMethod.ToLower())
            {
                case "get":
                    return await service.Get();
                case "post":
                    return await service.Post();
                case "delete":
                    return await service.Delete();
                default:
                    throw new NotImplementedException();
            }
        }

        private async Task<T> _stringParameterApiCall<T>(ApiCallInfo apiCallInfo) where T : class
        {
            var service = RestService.For<IDynamicRefit<T, string>>(new HttpClient(new AuthorizedHttpClientHandler(apiCallInfo.HeaderValues)) { BaseAddress = new Uri(apiCallInfo.Url) });

            switch (apiCallInfo.HttpMethod.ToLower())
            {
                case "post":
                    return await service.Post(apiCallInfo.Headers, JsonConvert.SerializeObject(apiCallInfo.StringQueryParamValues));
                default:
                    throw new NotImplementedException();
            }
        } 
        #endregion

    }
}
