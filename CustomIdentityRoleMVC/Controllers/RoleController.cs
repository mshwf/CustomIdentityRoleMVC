using CustomIdentityRoleMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.EntityFramework;
namespace CustomIdentityRoleMVC.Controllers
{
    public class RoleController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        // GET: Role
        public ActionResult Index()
        {
            return View(context.Roles.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Create(MIdentityRole role)
        {
            context.Roles.Add(role);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}