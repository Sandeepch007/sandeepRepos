using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace communitymodels
{
    public class Contact
    {
        [Key]
        public int cid {  get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string message { get; set; }
    }
}
