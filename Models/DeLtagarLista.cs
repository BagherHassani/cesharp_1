using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_InlämningsuppgiftCesharp.Models
{
    public class DeLtagarLista

    {
        public string FullName{ get; set; }
        public string Email { get; set; }

        public DeLtagarLista(string fullName, string email)
        {
            this.FullName = fullName;
            this.Email = email;
        }
        public override string ToString()
        {
           
            return string.Format(" Följande upggift är registrerad nu : \n {0}  \n {1} \n ", FullName, Email);
        }
    }


}
