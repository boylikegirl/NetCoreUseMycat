using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Common;
using DataAccess;
using IDAL;
using Microsoft.AspNetCore.Mvc;
using Model;
using NetCoreUseMycat.Models;

namespace NetCoreUseMycat.Controllers
{
    public class HomeController : Controller
    {
        
        private  IUserManageDAL _UserManageDAL;


        public HomeController(IUserManageDAL UserManageDAL)
        {
            _UserManageDAL = UserManageDAL;
        }

        public IActionResult Test()
        {
            UserInfo ui = new UserInfo();
            ui.UserName = "123123";
            _UserManageDAL.BeginTrains();
            _UserManageDAL.Insert(ui);
            _UserManageDAL.Commit();
            string test = AppConfigurtaion.GetAppSettings<FileConfig>("FileConfig").FileUpPath;
            test+= AppConfigurtaion.GetAppSettings("Timer");
            ViewData["Title"] = test;

            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
