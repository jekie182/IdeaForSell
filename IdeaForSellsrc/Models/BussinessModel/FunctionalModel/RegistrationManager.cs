using DBCore.Models.SeletcSQL;
using IdeaForSellsrc.Models.BussinessModel.RepoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdeaForSellsrc.Models.BussinessModel.FunctionalModel
{
    public class RegistrationManager
    {
        public RegistrationManager()
        {

        }

        public ModelResult CreateNewUser(string userLogin, string password)
        {
            try
            {
                var result = new DBSelect<int>().ExecuteSQLSingle("select COUNT(*) from Users where Login = @p0", new object[1] { userLogin });
                if (result.IsSuccess)
                {
                    if (result.Result == 0)
                    {
                        var newUser = new DBSelect<UserInfoData>().ExecuteSQLSingle(
@"EXEC Create_New_User @user_Name =@p0, @password =@p1", new object[2] {userLogin, password });
                        return new ModelResult() { IsSuccess = true, Result = newUser };
                    }
                    else
                        return new ModelResult() { IsSuccess = false, Message = "LoginAlreadyExist" };
                }
                else
                    return new ModelResult { IsSuccess = false, Message = result.Message };
            }
            catch (Exception e)
            {
                return new ModelResult { IsSuccess = false, Message = e.ToString()};
            }
        }
    }
}