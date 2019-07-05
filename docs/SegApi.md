# SegApiClient.Api.SegApi

All URIs are relative to *https://localhost/seg*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SegsSegAdd**](SegApi.md#segssegadd) | **POST** /api/v1/segs/add | Add seg detail.
[**SegsSegCode**](SegApi.md#segssegcode) | **GET** /api/v1/segs/codes/{code} | Get seg detail by seg code.
[**SegsSegDelete**](SegApi.md#segssegdelete) | **DELETE** /api/v1/segs/{id} | Delete segs.
[**SegsSegId**](SegApi.md#segssegid) | **GET** /api/v1/segs/{id} | Get seg detail by seg key.
[**SegsSegList**](SegApi.md#segsseglist) | **GET** /api/v1/segs | Get list of segs.
[**SegsSegSearch**](SegApi.md#segssegsearch) | **POST** /api/v1/segs/search | Get segs base on search criteria.
[**SegsSegSegmatch**](SegApi.md#segssegsegmatch) | **POST** /api/v1/segs/match | Get segs match based on search criteria
[**SegsSegStatus**](SegApi.md#segssegstatus) | **PUT** /api/v1/segs/{id}/status | Update segs status.
[**SegsSegUpdate**](SegApi.md#segssegupdate) | **PUT** /api/v1/segs/{id} | Update seg.


<a name="segssegadd"></a>
# **SegsSegAdd**
> ResponseInfo SegsSegAdd (Seg seg = null)

Add seg detail.

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
    public class SegsSegAddExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SegApi();
            var seg = new Seg(); // Seg | Seg - object that needs to be added (optional) 

            try
            {
                // Add seg detail.
                ResponseInfo result = apiInstance.SegsSegAdd(seg);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SegApi.SegsSegAdd: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **seg** | [**Seg**](Seg.md)| Seg - object that needs to be added | [optional] 

### Return type

[**ResponseInfo**](ResponseInfo.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="segssegcode"></a>
# **SegsSegCode**
> RetrieveSeg SegsSegCode (string code)

Get seg detail by seg code.

To get seg detail by seg code.<br/><br/><b>Roles</b><br/>Denied Anonymous Access<br/>seg.reviewer<br/> seg.admin

### Example
```csharp
using System;
using System.Diagnostics;
using SegApiClient.Api;
using SegApiClient.Client;
using SegApiClient.Model;

namespace Example
{
    public class SegsSegCodeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SegApi();
            var code = code_example;  // string | Seg code for which wants seg.

            try
            {
                // Get seg detail by seg code.
                RetrieveSeg result = apiInstance.SegsSegCode(code);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SegApi.SegsSegCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**| Seg code for which wants seg. | 

### Return type

[**RetrieveSeg**](RetrieveSeg.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="segssegdelete"></a>
# **SegsSegDelete**
> ResponseInfo SegsSegDelete (Guid? id)

Delete segs.

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
    public class SegsSegDeleteExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SegApi();
            var id = new Guid?(); // Guid? | Passes id

            try
            {
                // Delete segs.
                ResponseInfo result = apiInstance.SegsSegDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SegApi.SegsSegDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| Passes id | 

### Return type

[**ResponseInfo**](ResponseInfo.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="segssegid"></a>
# **SegsSegId**
> RetrieveSeg SegsSegId (Guid? id)

Get seg detail by seg key.

To get seg detail by seg key.<br/><br/><b>Roles</b><br/>Denied Anonymous Access<br/>seg.reviewer<br/> seg.admin

### Example
```csharp
using System;
using System.Diagnostics;
using SegApiClient.Api;
using SegApiClient.Client;
using SegApiClient.Model;

namespace Example
{
    public class SegsSegIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SegApi();
            var id = new Guid?(); // Guid? | Seg key for which wants seg.

            try
            {
                // Get seg detail by seg key.
                RetrieveSeg result = apiInstance.SegsSegId(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SegApi.SegsSegId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| Seg key for which wants seg. | 

### Return type

[**RetrieveSeg**](RetrieveSeg.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="segsseglist"></a>
# **SegsSegList**
> List<RetrieveSeg> SegsSegList ()

Get list of segs.

To get list of segs.<br/><br/><b>Roles</b><br/>Denied Anonymous Access<br/>seg.reviewer<br/> seg.admin

### Example
```csharp
using System;
using System.Diagnostics;
using SegApiClient.Api;
using SegApiClient.Client;
using SegApiClient.Model;

namespace Example
{
    public class SegsSegListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SegApi();

            try
            {
                // Get list of segs.
                List&lt;RetrieveSeg&gt; result = apiInstance.SegsSegList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SegApi.SegsSegList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<RetrieveSeg>**](RetrieveSeg.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="segssegsearch"></a>
# **SegsSegSearch**
> List<RetrieveSeg> SegsSegSearch (SearchSeg searchSeg = null)

Get segs base on search criteria.

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
    public class SegsSegSearchExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SegApi();
            var searchSeg = new SearchSeg(); // SearchSeg | Search detail which wants seg. (optional) 

            try
            {
                // Get segs base on search criteria.
                List&lt;RetrieveSeg&gt; result = apiInstance.SegsSegSearch(searchSeg);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SegApi.SegsSegSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchSeg** | [**SearchSeg**](SearchSeg.md)| Search detail which wants seg. | [optional] 

### Return type

[**List<RetrieveSeg>**](RetrieveSeg.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="segssegsegmatch"></a>
# **SegsSegSegmatch**
> List<SegMatchResult> SegsSegSegmatch (SegMatch segMatch = null, bool? retrieveDefault = null)

Get segs match based on search criteria

<br/><br/><b>Roles</b><br/>Denied Anonymous Access<br/>seg.reader

### Example
```csharp
using System;
using System.Diagnostics;
using SegApiClient.Api;
using SegApiClient.Client;
using SegApiClient.Model;

namespace Example
{
    public class SegsSegSegmatchExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SegApi();
            var segMatch = new SegMatch(); // SegMatch | Seg match (optional) 
            var retrieveDefault = true;  // bool? | if retrieveDefault - true then 'Foster Care to Success' seg data will be returned (optional)  (default to true)

            try
            {
                // Get segs match based on search criteria
                List&lt;SegMatchResult&gt; result = apiInstance.SegsSegSegmatch(segMatch, retrieveDefault);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SegApi.SegsSegSegmatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **segMatch** | [**SegMatch**](SegMatch.md)| Seg match | [optional] 
 **retrieveDefault** | **bool?**| if retrieveDefault - true then &#39;Foster Care to Success&#39; seg data will be returned | [optional] [default to true]

### Return type

[**List<SegMatchResult>**](SegMatchResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="segssegstatus"></a>
# **SegsSegStatus**
> ResponseInfo SegsSegStatus (Guid? id, SegStatus updateStatus = null)

Update segs status.

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
    public class SegsSegStatusExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SegApi();
            var id = new Guid?(); // Guid? | Passes id
            var updateStatus = new SegStatus(); // SegStatus | Segs - object that needs to be updated (optional) 

            try
            {
                // Update segs status.
                ResponseInfo result = apiInstance.SegsSegStatus(id, updateStatus);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SegApi.SegsSegStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| Passes id | 
 **updateStatus** | [**SegStatus**](SegStatus.md)| Segs - object that needs to be updated | [optional] 

### Return type

[**ResponseInfo**](ResponseInfo.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="segssegupdate"></a>
# **SegsSegUpdate**
> ResponseInfo SegsSegUpdate (Guid? id, Seg updateSeg = null)

Update seg.

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
    public class SegsSegUpdateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SegApi();
            var id = new Guid?(); // Guid? | Passes id
            var updateSeg = new Seg(); // Seg | seg - object that needs to be updated (optional) 

            try
            {
                // Update seg.
                ResponseInfo result = apiInstance.SegsSegUpdate(id, updateSeg);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SegApi.SegsSegUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| Passes id | 
 **updateSeg** | [**Seg**](Seg.md)| seg - object that needs to be updated | [optional] 

### Return type

[**ResponseInfo**](ResponseInfo.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

