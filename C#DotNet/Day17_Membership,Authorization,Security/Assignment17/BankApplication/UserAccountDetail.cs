//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class UserAccountDetail
    {
        [Key] [Required] [RegularExpression("[A-Za-z]{1,10}[0-9]{1,10}")]
        public string AccNo { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Full_Name { get; set; }
        [Required]
        public string AccountType { get; set; }
    }
}
