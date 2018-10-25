﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ConstosoSite.Models
{
    public class Metadata
    {
        public class StudentMetadata
        {
            [StringLength(50)]
            [Display(Name = "Last Name")]
            public string LastName;

            [StringLength(50)]
            [Display(Name = "Middle Name")]
            public string MiddleName;

            [Display(Name = "Enrollment Date")]
            public Nullable<System.DateTime> EnrollmentDate;
        }

        public class EnrollmentMetadata
        {
            [Range(0, 4)]
            public Nullable<decimal> Grade;
        }

    }
}