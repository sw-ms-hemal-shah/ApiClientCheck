# SegApiClient.Api.CheckTypeApi

All URIs are relative to *https://localhost/seg*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Checktype**](CheckTypeApi.md#checktype) | **GET** /api/v1/segs/checkType | Gets check type.


<a name="checktype"></a>
# **Checktype**
> List<CardType> Checktype ()

Gets check type.

<br/><br/><b>Roles</b><br/>Denied Anonymous Access<br/>seg.reviewer<br/> seg.admin

### Example
```csharp
using System;
using System.Diagnostics;
using SegApiClient.Api;
using SegApiClient.Client;
using SegApiClient.Model;

namespace Example
{
    public class ChecktypeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CheckTypeApi();

            try
            {
                // Gets check type.
                List&lt;CardType&gt; result = apiInstance.Checktype();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckTypeApi.Checktype: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<CardType>**](CardType.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

