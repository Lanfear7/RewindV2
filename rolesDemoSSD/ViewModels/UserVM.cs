﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace rolesDemoSSD.ViewModels
{
    public class UserVM
    {
        [Key]
        public string Email { get; set; }
    }

}
