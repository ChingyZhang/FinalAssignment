using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.DAL.DB;
using CMS.DAL.Model;

namespace CMS.DAL.DAO
{
    /// <summary>
    /// 对用户进行增删改查
    /// </summary>
    public class UserDAO
    {
        #region 添加新用户+AddUser
        /// <summary>
        /// 添加新用户
        /// </summary>
        /// <param name="userModel"></param>
        /// <returns></returns>
        public bool AddUser(UserModel userModel)
        {
            using (CMSEntities db = new CMSEntities())
            {
                DB.users user = userModel.ToDBUser();
                db.users.Add(user);
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        } 
        #endregion

        #region 删除用户+DeleteUser
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="userModel"></param>
        /// <returns></returns>
        public bool DeleteUser(UserModel userModel)
        {
            using (CMSEntities db = new CMSEntities())
            {
                DB.users user = db.users.FirstOrDefault(x => x.u_id == userModel.u_id);
                if (user == null)
                {
                    return true;
                }
                db.users.Remove((DB.users)userModel);
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }

        } 
        #endregion

        #region 修改用户+ModifyUser
        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="userModel"></param>
        /// <returns></returns>
        public bool ModifyUser(UserModel userModel)
        {
            using (CMSEntities db = new CMSEntities())
            {
                DB.users user = db.users.FirstOrDefault(x => x.u_id == userModel.u_id);
                if (user == null)
                {
                    return false;
                }
                user = (DB.users)userModel;
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        } 
        #endregion

        #region 获取所有用户信息+GetAllUsers
        /// <summary>
        /// 获取所有用户信息
        /// </summary>
        /// <returns></returns>
        public List<UserModel> GetAllUsers()
        {
            using (CMSEntities db = new CMSEntities())
            {
                List<DB.users> userList = db.users.ToList();
                if (userList == null || userList.Count() == 0)
                {
                    return null;
                }
                List<UserModel> userModelList = new List<UserModel>();
                foreach (DB.users user in userList)
                {
                    UserModel userModel = new UserModel
                    {
                        u_id = user.u_id,
                        ut_id = user.ut_id,
                        ut_name = (from UserTitle in db.usertitle
                                   where Convert.ToUInt32(UserTitle.ut_id) == user.ut_id
                                   select UserTitle.ut_name).ToString(),
                        u_account = user.u_account,
                        u_password = user.u_password,
                        u_gender = user.u_gender,
                        u_stucentid = user.u_stucentid,
                        u_name = user.u_name,
                        u_political = user.u_political,
                        u_badroom = user.u_badroom,
                        u_phone = user.u_phone,
                        u_qq = user.u_qq,
                        u_birthday = user.u_birthday,
                        u_hometown = user.u_hometown,
                        u_nation = user.u_nation,
                        u_lastlogintime = user.u_lastlogintime,
                        u_lastloginip = user.u_lastloginip,
                        u_logintime = user.u_logintime
                    };
                    userModelList.Add(userModel);
                }
                return userModelList;
            }
        } 
        #endregion

        #region 添加用户类型+AddUserType
        /// <summary>
        /// 添加用户类型
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        public bool AddUserType(string typeName)
        {
            using (CMSEntities db = new CMSEntities())
            {
                DB.usertitle type = new usertitle
                {
                    ut_name = typeName,
                    ut_detele = 0
                };
                db.usertitle.Add(type);
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        } 
        #endregion

        #region 删除用户类型+RemoveUserType
        /// <summary>
        /// 删除用户类型
        /// </summary>
        /// <param name="typeID"></param>
        /// <returns></returns>
        public bool RemoveUserType(int typeID)
        {
            using (CMSEntities db = new CMSEntities())
            {
                DB.usertitle type = db.usertitle.FirstOrDefault(x => x.ut_id == typeID);
                if (type == null)
                {
                    return true;
                }
                db.usertitle.Remove(type);
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        } 
        #endregion

        #region 获取用户类型+GetUserType
        /// <summary>
        /// 获取用户类型
        /// </summary>
        /// <returns></returns>
        public List<DB.usertitle> GetUserType()
        {
            using (CMSEntities db = new CMSEntities())
            {
                return db.usertitle.ToList();                
            }
        }
        #endregion
    }
}
