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
    
    public partial class AccountType
    {
        public AccountType()
        {
            this.Accounts = new HashSet<Account>();
        }
    
        public int Id { get; set; }
        public string AccountTypeName { get; set; }
    
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
