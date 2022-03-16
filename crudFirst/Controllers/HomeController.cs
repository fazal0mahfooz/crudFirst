using crudFirst.DB_context;
using crudFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crudFirst.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            studentEntities obj = new studentEntities();
            List<class1 >obj1 = new List<class1>();


            var res = obj.student_tbl.ToList();

            foreach (var item in res)
            {
                obj1.Add(new class1
                {

                    id = item.id, 
                    name= item.name,
                    email=item.email,
                    DOB=item.DOB,
                    address=item.address




                }); 
                
            }

            return View(obj1);
        }

      
    }
}