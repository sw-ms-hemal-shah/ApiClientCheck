# SegApiClient.Api.CardTypeApi

All URIs are relative to *https://localhost/seg*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Cardtype**](CardTypeApi.md#cardtype) | **GET** /api/v1/segs/cardType | Gets card type.


<a name="cardtype"></a>
# **Cardtype**
> List<CardType> Cardtype ()

Gets card type.

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
    public class CardtypeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CardTypeApi();

            try
            {
                // Gets card type.
                List&lt;CardType&gt; result = apiInstance.Cardtype();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardTypeApi.Cardtype: " + e.Message );
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

