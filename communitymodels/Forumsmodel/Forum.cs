using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace communitymodels.Forumsmodel
{
    public class Forum
    {
        [Key] 
        public int QuestionId { get; set; }
        public string Question { get; set; }
        public int LoginId {  get; set; }

        [NotMapped]
        public virtual Login? login { get; set; }
        
    }
}
