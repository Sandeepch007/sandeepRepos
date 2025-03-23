using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HModels
{
    public class SecurityQuestion
    {
        [Key]
        public int SecId { get; set; }
        public string? securityQuestion{ get; set; }
       
    }
}
