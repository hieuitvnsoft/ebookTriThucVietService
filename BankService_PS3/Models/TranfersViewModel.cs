using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session03.Models.ViewModels
{
    public class TranfersViewModel
    {
        public int TranferId { get; set; }
        public string AccountSender { get; set; }
        public string AcountReceiver { get; set; }
        public float Amount { get; set; }
        public DateTime LongDate { get; set; }
        public string AccountCode { get; set; }
    }
}