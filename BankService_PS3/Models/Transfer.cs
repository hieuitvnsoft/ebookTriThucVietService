//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankService_PS3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transfer
    {
        public int TransferId { get; set; }
        public string AccountSender { get; set; }
        public string AccountReceiver { get; set; }
        public Nullable<double> Amount { get; set; }
        public Nullable<System.DateTime> LogDate { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Account Account1 { get; set; }
    }
}
