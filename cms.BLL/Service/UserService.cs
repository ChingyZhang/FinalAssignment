using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cms.BLL.Infrastructure;
using CMS.DAL.Model;
using CMS.DAL.DAO;
using CMS.DAL.DB;

namespace cms.BLL.Service
{
    public class UserService : IUserService
    {
        UserDAO userDAO = new UserDAO();

        public bool AddUserType(string typeName)
        {
            return userDAO.AddUserType(typeName);
        }

        public bool RemoveUserType(int typeID)
        {
            return userDAO.RemoveUserType(typeID);
        }

        public List<CMS.DAL.DB.usertitle> GetUserType()
        {
            return userDAO.GetUserType();
        }

        public bool AddUser(CMS.DAL.Model.UserModel userModel)
        {
            return userDAO.AddUser(userModel);
        }

        public bool DeleteUser(CMS.DAL.Model.UserModel userModel)
        {
            return userDAO.DeleteUser(userModel);
        }

        public bool ModifyUser(CMS.DAL.Model.UserModel userModel)
        {
            return userDAO.ModifyUser(userModel);
        }

        public UserModel UserLogin(CMS.DAL.Model.UserModel userModel)
        {
            List<UserModel> userModelList = userDAO.GetAllUsers();
            var user = userModelList.FirstOrDefault(x => x.u_stucentid == userModel.u_stucentid && x.u_password == userModel.u_password);
            return user;
        }

        
    }
}
