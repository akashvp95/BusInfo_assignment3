using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusInfo_Assignment3.Models;

namespace BusInfo_Assignment3.Controllers
{
    public class tblBusInfoController : Controller
    {

        BusInfo_assignmentEntities db = new BusInfo_assignmentEntities();
        public ActionResult Index()
        {
            return View((from c in db.tblBusInfoes
                        where c.BoardPoint == "MUM"
                        select c));
        }
    }
}