//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KanbWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Account
    {
        public Account()
        {
            this.CreditCards = new HashSet<CreditCard>();
            this.DebitCards = new HashSet<DebitCard>();
            this.Transactions = new HashSet<Transaction>();
            this.Transfers = new HashSet<Transfer>();
            this.Transfers1 = new HashSet<Transfer>();
        }
    
        public int Id { get; set; }
        [Display(Name="Customer")]
        public int CustomerID { get; set; }
        public int AccountTypeID { get; set; }
        public float Balance { get; set; }
    
        public virtual AccountType AccountType { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<CreditCard> CreditCards { get; set; }
        public virtual ICollection<DebitCard> DebitCards { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<Transfer> Transfers { get; set; }
        public virtual ICollection<Transfer> Transfers1 { get; set; }
    }
}
