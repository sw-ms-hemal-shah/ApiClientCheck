using System.Collections.Generic;

namespace component.netcore.api.refit.info
{
    public class ApiCallInfo
    {
        public Dictionary<string, string> HeaderValues { get; set; }
        public string Url { get; set; }
        public string HttpMethod { get; set; }
        public object QueryParamValues { get; set; }
        public string StringQueryParamValues { get; set; }
        public string Headers { get; set; }
    }
}
