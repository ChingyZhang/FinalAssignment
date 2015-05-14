using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cms.BLL.Infrastructure;
using cms.BLL.Service;
using CMS.DAL.DB;

namespace cms.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/        
        //
		//czdsafda

        IUserService userService { get; set; }

        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            if (userService == null)
            {
                userService = new UserService();
            }
            base.Initialize(requestContext);
        }

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult ModifyUserType()
        {
            List<CMS.DAL.DB.usertitle> typeList = userService.GetUserType();
            ViewData["typeList"] = typeList;
            return PartialView();
        }

        public JsonResult AddUserType(string typeName)
        {
            bool flag = userService.AddUserType(typeName);
            var json = new
            {
                Flag = flag.ToString()
            };
            return Json(json);
        }

        public JsonResult RemoveUserType(int typeID)
        {
            bool flag = userService.RemoveUserType(typeID);
            var json = new
            {
                Flag = flag.ToString()                
            };
            return Json(json);
        }

        public PartialViewResult AddUser()
        {
            return PartialView();
        }

        [HttpPost]
        public JsonResult AddUser(CMS.DAL.Model.UserModel userModel)
        {
            bool flag = userService.AddUser(userModel);
            var jsonData = new
            {
                Flag = flag,
            };
            return Json(jsonData);
        }

    }
}
