using component.netcore.apiclient.seg.Client;
using component.netcore.apiclient.seg.v1.Api;
using System;

namespace ClientConsumeRestSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Configuration configuration = new Configuration();
            configuration.BasePath = "http://gdedev02.gdeacu.com/seg";
            configuration.AccessToken = "577ae3287562fdfdfbf4d299b361959f94e82a4f8d67de59d4bf9c77ff735ca4";

            GroupApi apiClient = new GroupApi();
            apiClient.Configuration = configuration;

            //Get All Groups
            var data = apiClient.SegsGroupList();
            Console.WriteLine("Total Group Count is :" + data.Count.ToString());

            #region Commented Code
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
            //var dataDelete = apiClient.SegsGroupDelete(new Guid("d90dc1ed-334c-41b3-a169-d9a08efe1e17"));
            //Console.WriteLine(dataDelete);
            #endregion

            Console.ReadLine();
        }
    }
}
