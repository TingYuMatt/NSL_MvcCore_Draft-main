﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Nsl_Api.Models.EFModels
{
    public partial class Message
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int? RecipientId { get; set; }
        public string MessageText { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}