using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsEvents.Models
{
    public class Admin
    {
        [DisplayFormat(NullDisplayText = "", ApplyFormatInEditMode = true)]
        public String Username { get; set; }
        [DisplayFormat(NullDisplayText = "", ApplyFormatInEditMode = true)]
        public String Password { get; set; }

    }
}
