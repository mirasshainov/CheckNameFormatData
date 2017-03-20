using AttrubuteLearn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttrubuteLearn.Controllers
{
    public class FriendsController : Controller
    {
        // GET: Friends
        public ActionResult Create()
        {
			Person newFriend = new Person();
			return View(newFriend);
        }

		[HttpPost]
		public ActionResult Create(Person friendToCreate) {
			if(ModelState.IsValid) {
				return Redirect("/");
			}
			return View(friendToCreate);
		}
    }
}