using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.DAL.Model;
using CMS.DAL.DB;

namespace cms.BLL.Infrastructure
{
    public interface IUserService
    {
        bool AddUser(UserModel userModel);

        bool DeleteUser(UserModel userModel);

        bool ModifyUser(UserModel userModel);

        UserModel UserLogin(UserModel userModel);

        bool AddUserType(string typeName);

        bool RemoveUserType(int typeID);

        List<CMS.DAL.DB.usertitle> GetUserType();
    }
}
