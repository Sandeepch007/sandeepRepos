using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace communitymodels
{
    public class SecurityQuestions
    {
        [Key]
        public int Questionid { get; set; }
        public string? Secquestion {  get; set; }
    }
}
