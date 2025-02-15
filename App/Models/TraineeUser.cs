﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace App.Models
{
    public class TraineeUser
    {
        [Key]
        public string Id { get; set; }
        public string UserName { get; set; }
        [DisplayName("Full Name")]

        [Required]
        public string FullName { get; set; }
        [Required]
        [DisplayName("Date Of Birth")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string Telephone { get; set; }
        [DisplayName("Programming Language")]
        public string mainProgrammingLanguage { get; set; }
        [DisplayName("Toeic Score")]
        public string ToeicScore { get; set; }
        public string Department { get; set; }
        [DisplayName("Email Address")]
        public string EmailAddress { get; set; }
        [ForeignKey("Id")]
        public ApplicationUser ApplicationUser { get; set; }
    }
}