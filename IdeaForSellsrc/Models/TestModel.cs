using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DBCore;
using System.Data.Entity;
using DBCore.Models.BaseSQL;
using DBCore.Models.SeletcSQL;
using IdeaForSellsrc.Models.ViewModel;
using IdeaForSellsrc.Models.ViewModel.Recources;

namespace IdeaForSellsrc.Models
{
    public static class TestModel
    {
        public static void Execute()
        {
            BaseView<IndexViewResourseManager> baseV = new BaseView<IndexViewResourseManager>
                (
                    new SessionUserData()
                    {
                        Id = "1",
                        Lang = Language.ua_UA,
                        TimeZone = "+2"
                    },
                    new IndexViewResourseManager(Language.ua_UA)  
                );

            //var list = new DBSelect<User>().ExecuteSQLList("select * from Users");
            //var a = new DBSelect<User>().ExecuteSQLSingle("select * from Users where Id = @p0", new object[1] { 1 });
            //var b = new DBSelect<User>().ExecuteSQLSingleAsJson("select * from Users where Id = @p0", new object[1] { 1 });
            //var c = new DBSelect<User>().ExecuteSQLListAsJson("select * from Users where Id > @p0", new object[1] { 0 });
        }

        public class User {
            public int Id { get; set; }
            public string Login { get; set; }
            public string Password { get; set; }
            public int UserRoleId { get; set; }
        }
    }
}