using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using communitymodels;

namespace communitymodels
{
    public class Login
    {
        [Key]
        public int Loginid { get; set; }
        public string? Fullname { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Secanswer { get; set; }
        public bool Status {  get; set; }
        public int Questionid { get; set; }

        

    }
}

