# SegApiClient.Api.GroupApi

All URIs are relative to *https://localhost/seg*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SegsGroupAdd**](GroupApi.md#segsgroupadd) | **POST** /api/v1/segs/groups | Add seg group.
[**SegsGroupDelete**](GroupApi.md#segsgroupdelete) | **DELETE** /api/v1/segs/groups/{id} | To delete seg group.
[**SegsGroupGet**](GroupApi.md#segsgroupget) | **GET** /api/v1/segs/groups/{id} | Get seg group by group id.
[**SegsGroupList**](GroupApi.md#segsgrouplist) | **GET** /api/v1/segs/groups | Get list of seg groups.
[**SegsGroupUpdate**](GroupApi.md#segsgroupupdate) | **PUT** /api/v1/segs/groups/{id} | To update seg group.


<a name="segsgroupadd"></a>
# **SegsGroupAdd**
> ResponseInfo SegsGroupAdd (Group group = null)

Add seg group.

To add seg group.<br/><br/><b>Roles</b><br/>Denied Anonymous Access<br/>seg.admin

### Example
```csharp
using System;
using System.Diagnostics;
using SegApiClient.Api;
using SegApiClient.Client;
using SegApiClient.Model;

namespace Example
{
    public class SegsGroupAddExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupApi();
            var group = new Group(); // Group | group - object that needs to be added (optional) 

            try
            {
                // Add seg group.
                ResponseInfo result = apiInstance.SegsGroupAdd(group);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.SegsGroupAdd: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | [**Group**](Group.md)| group - object that needs to be added | [optional] 

### Return type

[**ResponseInfo**](ResponseInfo.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="segsgroupdelete"></a>
# **SegsGroupDelete**
> ResponseInfo SegsGroupDelete (Guid? id)

To delete seg group.

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
    public class SegsGroupDeleteExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // To delete seg group.
                ResponseInfo result = apiInstance.SegsGroupDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.SegsGroupDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 

### Return type

[**ResponseInfo**](ResponseInfo.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="segsgroupget"></a>
# **SegsGroupGet**
> RetrieveGroup SegsGroupGet (Guid? id)

Get seg group by group id.

To get seg group by group id.<br/><br/><b>Roles</b><br/>Denied Anonymous Access<br/>seg.reviewer<br/> seg.admin

### Example
```csharp
using System;
using System.Diagnostics;
using SegApiClient.Api;
using SegApiClient.Client;
using SegApiClient.Model;

namespace Example
{
    public class SegsGroupGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupApi();
            var id = new Guid?(); // Guid? | Seg group id for which wants group.

            try
            {
                // Get seg group by group id.
                RetrieveGroup result = apiInstance.SegsGroupGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.SegsGroupGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| Seg group id for which wants group. | 

### Return type

[**RetrieveGroup**](RetrieveGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="segsgrouplist"></a>
# **SegsGroupList**
> List<RetrieveGroup> SegsGroupList ()

Get list of seg groups.

To get list of seg groups.<br/><br/><b>Roles</b><br/>Denied Anonymous Access<br/>seg.reviewer<br/> seg.admin

### Example
```csharp
using System;
using System.Diagnostics;
using SegApiClient.Api;
using SegApiClient.Client;
using SegApiClient.Model;

namespace Example
{
    public class SegsGroupListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupApi();

            try
            {
                // Get list of seg groups.
                List&lt;RetrieveGroup&gt; result = apiInstance.SegsGroupList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.SegsGroupList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<RetrieveGroup>**](RetrieveGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="segsgroupupdate"></a>
# **SegsGroupUpdate**
> ResponseInfo SegsGroupUpdate (Guid? id, Group group = null)

To update seg group.

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
    public class SegsGroupUpdateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupApi();
            var id = new Guid?(); // Guid? | Passes id.
            var group = new Group(); // Group | group - object that needs to be updated (optional) 

            try
            {
                // To update seg group.
                ResponseInfo result = apiInstance.SegsGroupUpdate(id, group);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.SegsGroupUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| Passes id. | 
 **group** | [**Group**](Group.md)| group - object that needs to be updated | [optional] 

### Return type

[**ResponseInfo**](ResponseInfo.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

