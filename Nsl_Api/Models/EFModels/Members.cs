﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Nsl_Api.Models.EFModels
{
    public partial class Members
    {
        public Members()
        {
            ArticlesClick = new HashSet<ArticlesClick>();
            ChatHistories = new HashSet<ChatHistories>();
            CouponUsageHistory = new HashSet<CouponUsageHistory>();
            MembersConsumptionRecords = new HashSet<MembersConsumptionRecords>();
            MembersTutorRecords = new HashSet<MembersTutorRecords>();
            MembersTutorStock = new HashSet<MembersTutorStock>();
            ShoppingCart = new HashSet<ShoppingCart>();
            TeacherId = new HashSet<TeacherId>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Birthday { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string EncryptedPassword { get; set; }
        public string Salt { get; set; }
        public bool? Gender { get; set; }
        public int? CityId { get; set; }
        public int? AreaId { get; set; }
        public string ImageName { get; set; }
        public bool? EmailCheck { get; set; }
        public string EmailToken { get; set; }
        public string LineId { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public int Role { get; set; }

        public virtual Areas Area { get; set; }
        public virtual Citys City { get; set; }
        public virtual Roles RoleNavigation { get; set; }
        public virtual ChatNumber ChatNumber { get; set; }
        public virtual ICollection<ArticlesClick> ArticlesClick { get; set; }
        public virtual ICollection<ChatHistories> ChatHistories { get; set; }
        public virtual ICollection<CouponUsageHistory> CouponUsageHistory { get; set; }
        public virtual ICollection<MembersConsumptionRecords> MembersConsumptionRecords { get; set; }
        public virtual ICollection<MembersTutorRecords> MembersTutorRecords { get; set; }
        public virtual ICollection<MembersTutorStock> MembersTutorStock { get; set; }
        public virtual ICollection<ShoppingCart> ShoppingCart { get; set; }
        public virtual ICollection<TeacherId> TeacherId { get; set; }
    }
}