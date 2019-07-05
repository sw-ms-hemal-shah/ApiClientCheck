# SegApiClient.Api.HealthCheckApi

All URIs are relative to *https://localhost/seg*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HealthcheckCheck**](HealthCheckApi.md#healthcheckcheck) | **GET** /api/v1/healthcheck | 


<a name="healthcheckcheck"></a>
# **HealthcheckCheck**
> void HealthcheckCheck ()



### Example
```csharp
using System;
using System.Diagnostics;
using SegApiClient.Api;
using SegApiClient.Client;
using SegApiClient.Model;

namespace Example
{
    public class HealthcheckCheckExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HealthCheckApi();

            try
            {
                apiInstance.HealthcheckCheck();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthCheckApi.HealthcheckCheck: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

