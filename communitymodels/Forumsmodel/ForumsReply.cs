using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace communitymodels.Forumsmodel
{
    public class ForumsReply
    {
        [Key]
        public int ReplyId {  get; set; }
        public int QuestionId { get; set; }
        public string Reply {  get; set; }
        public int LoginId { get; set; }

        [NotMapped]
        public virtual Forum? Forum { get; set; }

       


    }
}
