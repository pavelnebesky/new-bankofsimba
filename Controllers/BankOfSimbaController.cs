using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bankOfSimba.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bankOfSimba.Controllers
{
    [Route("")]
    public class BankOfSimbaController : Controller
    {

        public static List<BankAccount> accounts = new List<BankAccount>()
            {
                new BankAccount("Simba", 2000, "lion", true, true),
                new BankAccount("Bhati", 200, "fox", false, true),
                new BankAccount("Chama", 1000, "elephant", false, true),
                new BankAccount("Herr Rhino", 1500, "rhinoceros", false, false),
                new BankAccount("Boma", 1000, "buffalo", false, false)
            };

        // GET: /<controller>/

        [Route("show")]
        public IActionResult Show()
        {
            BankAccount bankAccount = new BankAccount("Simba", 2000, "lion", true, true);

            return View(bankAccount);
        }

        [Route("html")]
        public IActionResult Html()
        {
      
            return View();
        }

        [Route("accounts")]
        public IActionResult Accounts(bool raise, int id, string name, int ballance, string animalType, string isKingStr, string isGoodStr)
        {
            if (raise)
            {
                
                    if (accounts[id].IsKing)
                    {
                        accounts[id].Balance += 100;
                    }
                    else
                    {
                        accounts[id].Balance += 10;
                    }
                
            }

            bool isKing;
            bool isGood;

            if (name != null)
            {
                if (isKingStr == "checked")
                {
                    isKing = true;
                }
                else
                {
                    isKing = false;
                }
                if (isGoodStr == "checked")
                {
                    isGood = true;
                }
                else
                {
                    isGood = false;
                }
                accounts.Add(new BankAccount(name, ballance, animalType, isKing, isGood));

            }

            return View(accounts);
        }

    }
}
