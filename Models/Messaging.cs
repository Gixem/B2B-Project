//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace B2BProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Messaging
    {
        public int Id { get; set; }
        public int Sender_Id { get; set; }
        public int Recipient_Id { get; set; }
        public string Message { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual Users Users { get; set; }
        public virtual Users Users1 { get; set; }
    }
}
