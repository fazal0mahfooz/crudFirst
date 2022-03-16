using crudFirst.DB_context;
using crudFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crudFirst.Controllers
{
    public class postController : Controller
    {
        studentEntities obj = new studentEntities();
        student_tbl objnew = new student_tbl();

        // GET: post

        [HttpGet]

        public ActionResult Adddata()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Adddata(class1 obj1)
        {
           
            objnew.id = obj1.id;
            objnew.name = obj1.name;
            objnew.email = obj1.email;
            objnew.DOB = obj1.DOB;
            objnew.address = obj1.address;

            obj.student_tbl.Add(objnew);
            obj.SaveChanges();
            return View();
        }
    }
}