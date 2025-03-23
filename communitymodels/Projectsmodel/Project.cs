using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace communitymodels.Projectsmodel
{
    public class Project
    {
        [Key]
        public int ProjectId {  get; set; }
        public string ProjectType {  get; set; }
        public string FileName {  get; set; }
        public string FileType {  get; set; }
        public int LoginId { get; set; }

        [NotMapped]
        public virtual Login? login { get; set; }
    }
}
