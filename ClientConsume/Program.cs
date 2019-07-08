using System;
using component.netcore.api.refit;
using component.netcore.api.refit.interfaces;
using SegApiClient.Api;
using SegApiClient.Client;
using SegApiClient.Model;

namespace ClientConsume
{
    class Program
    {
        static void Main(string[] args)
        {
            Configuration configuration = new Configuration();
            configuration.BasePath = "http://gdedev02.gdeacu.com/seg";
            configuration.AccessToken = "95da0b262752366e9c5521f9eab633f7b7960fc4d9fd9c9fe1916fe6bcf3fc14";

            GroupApi apiClient = new GroupApi(new ApiCaller());
            apiClient.Configuration = configuration;

            //Get All Groups
            //var data = apiClient.SegsGroupList();
            //Console.WriteLine("Total Group Count is :" + data.Count.ToString());            

            //Add Group
            //Group grp = new Group("Group By Client", "Desc of Group By Client", "9547");

            //var dataAdd = apiClient.SegsGroupAdd(grp);
            //Console.WriteLine(dataAdd.ResponseId);            

            //Search Group            
            //var dataSearch = apiClient.SegsGroupGet(new Guid("d90dc1ed-334c-41b3-a169-d9a08efe1e17"));
            //Console.WriteLine(dataSearch);

            ////Edit Group
            //dataSearch.Group.Description = "Edited desc";
            //var dataEdit = apiClient.SegsGroupUpdate(dataSearch.GroupId, dataSearch.Group);
            //Console.WriteLine(dataEdit);

            //Delete Group
            var dataDelete = apiClient.SegsGroupDelete(new Guid("d90dc1ed-334c-41b3-a169-d9a08efe1e17"));
            Console.WriteLine(dataDelete);

            Console.ReadLine();
        }
    }
}
