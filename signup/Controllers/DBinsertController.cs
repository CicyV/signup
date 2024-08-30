using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using signup.Models;

namespace signup.Controllers
{
    public class DBinsertController : Controller
    {
        AugDBEntities dbobj = new AugDBEntities();
        // GET: DBinsert
        public ActionResult Insert_pageload()
        {
            return View();
        }
        public ActionResult Insert_click(stinsert clsobj)
        {
            if (ModelState.IsValid)
            {
                dbobj.sp_stinsert(clsobj.name, clsobj.uname, clsobj.pwd, clsobj.cpwd);
                clsobj.msg = "inserted";
                return View("Insert_pageload", clsobj);
            }
            return View("Insert_pageload", clsobj);
        }
    }
}