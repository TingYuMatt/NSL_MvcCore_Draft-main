﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Nsl_Api.Models.EFModels
{
    public partial class TeachersDefaultTutorPeriods
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int WeekdayId { get; set; }
        public int PeriodId { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual TutorPeriod Period { get; set; }
        public virtual TeacherId Teacher { get; set; }
        public virtual Week Weekday { get; set; }
    }
}