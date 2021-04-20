using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Montres.Models
{
    public class Usuario
    {
        public string user { set; get; }
        public string contra { set; get; }

        public Usuario(string user, string contra)
        {
            this.user = user;
            this.contra = contra;
        }
    }
}