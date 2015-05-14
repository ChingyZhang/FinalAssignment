using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.DAL.Model
{
    public class UserModel : DB.users
    {
        /// <summary>
        /// 用户级别名称
        /// </summary>
        public string ut_name { get; set; }

        /// <summary>
        /// 将数据模型转换为数据库数据模型
        /// </summary>
        /// <returns></returns>
        public DB.users ToDBUser()
        {
            DB.users dbUser = new DB.users
            {

                ut_id = this.ut_id,
                u_account = this.u_account,
                u_password = this.u_password,
                u_gender = this.u_gender,
                u_stucentid = this.u_stucentid,
                u_name = this.u_name,
                u_political = this.u_political,
                u_badroom = this.u_badroom,
                u_phone = this.u_phone,
                u_qq = this.u_qq,
                u_birthday = this.u_birthday,
                u_hometown = this.u_hometown,
                u_nation = this.u_nation,
                u_lastlogintime = this.u_lastlogintime,
                u_lastloginip = this.u_lastloginip,
                u_logintime = this.u_logintime
            };

            if (this.u_id != null && this.u_id > 0)
            {
                dbUser.u_id = this.u_id;
            }
            return dbUser;
        }

    }
}
