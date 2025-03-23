using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using communityDal.ProjectDal;
using communitymodels.Projectsmodel;

namespace communityBal.ProjectBal
{
    public class ProjectBLogic
    {
        private readonly ProjectRepository _repo;
        public ProjectBLogic(ProjectRepository repo)
        {
            _repo = repo;
        }
        public List<Project> prolist()
        {
            try
            {
                return _repo.projectlist();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool propost(Project pro)
        {
            try
            {
                return _repo.postproject(pro);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool deletepro(int id)
        {
            try
            {
                return _repo.deleteproject(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool proupdate(Project pro)
        {
            try
            {
                return _repo.updateproject(pro);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
