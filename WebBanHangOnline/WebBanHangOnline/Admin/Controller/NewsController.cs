﻿using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHangOnline.Models;
using WebBanHangOnline.Models.EF;
namespace WebBanHangOnline.Areas.Admin.Controllers
{
 
    public class NewsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
    }
}
