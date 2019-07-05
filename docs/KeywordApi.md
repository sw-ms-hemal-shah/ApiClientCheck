# SegApiClient.Api.KeywordApi

All URIs are relative to *https://localhost/seg*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SegKeywordDelete**](KeywordApi.md#segkeyworddelete) | **DELETE** /api/v1/segs/{segId}/keywords/{keyword} | Delete Keyword
[**SegsKeywordAdd**](KeywordApi.md#segskeywordadd) | **POST** /api/v1/segs/keywords | This method will add keyword
[**SegsKeywordList**](KeywordApi.md#segskeywordlist) | **GET** /api/v1/segs/{segId}/keywords | This will return list of keyword by seg key


<a name="segkeyworddelete"></a>
# **SegKeywordDelete**
> ResponseInfo SegKeywordDelete (Guid? segId, string keyword)

Delete Keyword

<br/><br/><b>Roles</b><br/>Denied Anonymous Access<br/>seg.admin

### Example
```csharp
using System;
using System.Diagnostics;
using SegApiClient.Api;
using SegApiClient.Client;
using SegApiClient.Model;

namespace Example
{
    public class SegKeywordDeleteExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KeywordApi();
            var segId = new Guid?(); // Guid? | 
            var keyword = keyword_example;  // string | 

            try
            {
                // Delete Keyword
                ResponseInfo result = apiInstance.SegKeywordDelete(segId, keyword);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeywordApi.SegKeywordDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **segId** | [**Guid?**](Guid?.md)|  | 
 **keyword** | **string**|  | 

### Return type

[**ResponseInfo**](ResponseInfo.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="segskeywordadd"></a>
# **SegsKeywordAdd**
> ResponseInfo SegsKeywordAdd (AddKeyword keyword = null)

This method will add keyword

<br/><br/><b>Roles</b><br/>Denied Anonymous Access<br/>seg.admin

### Example
```csharp
using System;
using System.Diagnostics;
using SegApiClient.Api;
using SegApiClient.Client;
using SegApiClient.Model;

namespace Example
{
    public class SegsKeywordAddExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KeywordApi();
            var keyword = new AddKeyword(); // AddKeyword |  (optional) 

            try
            {
                // This method will add keyword
                ResponseInfo result = apiInstance.SegsKeywordAdd(keyword);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeywordApi.SegsKeywordAdd: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keyword** | [**AddKeyword**](AddKeyword.md)|  | [optional] 

### Return type

[**ResponseInfo**](ResponseInfo.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="segskeywordlist"></a>
# **SegsKeywordList**
> List<Keyword> SegsKeywordList (Guid? segId)

This will return list of keyword by seg key

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
    public class SegsKeywordListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KeywordApi();
            var segId = new Guid?(); // Guid? | 

            try
            {
                // This will return list of keyword by seg key
                List&lt;Keyword&gt; result = apiInstance.SegsKeywordList(segId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeywordApi.SegsKeywordList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **segId** | [**Guid?**](Guid?.md)|  | 

### Return type

[**List<Keyword>**](Keyword.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

