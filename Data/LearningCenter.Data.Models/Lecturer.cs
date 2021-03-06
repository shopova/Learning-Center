﻿namespace LearningCenter.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using LearningCenter.Data.Common.Models;

    public class Lecturer : BaseDeletableModel<string>
    {
        public Lecturer()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Feedbacks = new HashSet<Feedback>();
            this.Courses = new HashSet<Course>();
        }

        public virtual ICollection<Feedback> Feedbacks { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
