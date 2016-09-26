using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBlogger.Models;
using MVCBlogger.Service;

namespace MVCBlogger.Controllers
{
    public class MessageController : Controller
    {
        //get service
        DBService dbService = new DBService();


        // GET: /message/
        public ActionResult Index()
        {
            //put data to view
            return View(dbService.GetData());
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }


        public ActionResult Delete(int? articleId)
        {
            if (articleId.HasValue)
            {
                var isSuccessful = dbService.Delete(articleId);
                if (isSuccessful)
                {
                    return RedirectToAction("Index");
                }
            }       
          
            return RedirectToAction("Error");
        }

        [HttpPost]
        public ActionResult Create(string strAtricle, string strContent)
        {
            //call create method to save 
            dbService.DBCreate(strAtricle, strContent);
            //redirect to index
            return RedirectToAction("Index");
        }
    }
}