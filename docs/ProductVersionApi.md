# SegApiClient.Api.ProductVersionApi

All URIs are relative to *https://localhost/seg*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProductversionGet**](ProductVersionApi.md#productversionget) | **GET** /api/v1/productversion | 


<a name="productversionget"></a>
# **ProductversionGet**
> string ProductversionGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using SegApiClient.Api;
using SegApiClient.Client;
using SegApiClient.Model;

namespace Example
{
    public class ProductversionGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductVersionApi();

            try
            {
                string result = apiInstance.ProductversionGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductVersionApi.ProductversionGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

