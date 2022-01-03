using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            IList<Account> accounts = new List<Account>();
            accounts.Add(new Account() { ID = 205, AccHolderName = "Hemanth", AccHolderAddress = "Tirupathi" });
            accounts.Add(new Account() { ID = 206, AccHolderName = "Surya", AccHolderAddress = "Madanapalle" });
            accounts.Add(new Account() { ID = 207, AccHolderName = "Rohit", AccHolderAddress = "Chittor" });
            ViewData["accounts"] = accounts;
            return View();
        }
    }
}
