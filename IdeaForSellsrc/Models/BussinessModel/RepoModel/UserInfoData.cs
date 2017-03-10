using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdeaForSellsrc.Models.BussinessModel.RepoModel
{
    public class UserInfoData
    {
        //name in db roles table
        public string RoleName { get; set; }
        //login in db users table
        public string UserName { get; set; }
        //Location data in db personData
        public string LocationData { get; set; }
        //About info Data in db personData
        public string AboutInfoData { get; set; }
        //Id in db users table
        public int UserId { get; set; }
        //FirstName in db Persons table
        public string FirstName { get; set; }
        //Last name in db Persons table
        public string LastName { get; set; }
        //MiddleName in db Persons table 
        public string MiddleName { get; set; }
        //Date in db Dateofregisstation table
        public DateTime DateOfTheRegistrstion { get; set; }
    }
}