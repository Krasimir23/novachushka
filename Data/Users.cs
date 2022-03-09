using ASPChushka1.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace ASPChushka1.Data
{
    public class Users : IdentityUser

    {


        public string FullName { get; set; }

        

        

        public ICollection<Orders> Orders { get; set; }

    }
}
