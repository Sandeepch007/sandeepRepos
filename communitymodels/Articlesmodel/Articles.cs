using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace communitymodels.Articlesmodel
{
    public class Articles
    {

        [Key]
        public int ArticleId { get; set; }
        public string ArticleType {  get; set; }
        public string ArticleDescripstion { get; set; }
        public DateTime CurrentDate { get; set; }
        public int LoginId {  get; set; }
        [NotMapped]
        public virtual Login? login { get; set; }
    }
}
