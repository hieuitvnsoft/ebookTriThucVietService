using BankService_PS3.Models;
using Session03.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;


namespace BankService_PS3.Controllers
{
    
    public class TranfersController : ApiController
    {
       
        // GET: Tranfers
        BankEntities db = new BankEntities();
        [HttpPost]
        [Route("api/giao-dich-Ebook")]
        public string Tranfer(TranfersViewModel tranfer)
        {
            tranfer.AcountReceiver = "123123123123";
            tranfer.LongDate = DateTime.Now;

            var acc = db.Accounts.Find(tranfer.AccountSender);
            if (acc==null)
            {
                return "Tài khoản không đúng";
            }
            else
            {
                var acc2 = db.Accounts.Find(tranfer.AcountReceiver);

                if (tranfer.AccountCode.Equals(acc.AccountCode))
                {
                    if (acc.Balance > tranfer.Amount)
                    {

                        acc.Balance -= tranfer.Amount;
                        acc2.Balance += tranfer.Amount;
                        db.SaveChanges();
                        Transfer a = new Transfer();
                        a.AccountSender = tranfer.AccountSender;
                        a.AccountReceiver = tranfer.AcountReceiver;
                        a.Amount = tranfer.Amount;
                        a.LogDate = DateTime.Now;
                        db.Transfers.Add(a);
                        db.SaveChanges();
                        return "giao dịch thành công";
                    }
                    else { return "giao dịch thất bại"; }
                }
                else
                {
                    return "Mã PIN không chính xác";
                }
                

            }
           


        }
    }
}
