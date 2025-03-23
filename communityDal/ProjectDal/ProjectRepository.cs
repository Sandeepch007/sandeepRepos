using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using communitymodels;
using communitymodels.Projectsmodel;

namespace communityDal.ProjectDal
{
    public class ProjectRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProjectRepository(AppDbContext appDbContext) 
        {
            _appDbContext = appDbContext;
        }
        public List<Project> projectlist()
        {
            try
            {
                List<Project> list = new List<Project>();
                list=(from pro in _appDbContext.project join log in _appDbContext.Logins on pro.LoginId equals log.Loginid 
                      select(new Project
                      {
                          ProjectId=pro.ProjectId,
                          ProjectType=pro.ProjectType,
                          FileName=pro.FileName,
                          FileType=pro.FileType,
                          LoginId=pro.LoginId,
                          login =new Login{
                              Username=log.Username,
                          }
                      })).ToList();
                return list;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool postproject(Project pro)
        {
            bool issave=false;
            try
            {
                _appDbContext.project.Add(pro);
                _appDbContext.SaveChanges();
                issave=true;

            }
            catch (Exception)
            {

                throw;
            }
            return issave;
        }

        public bool deleteproject(int id) 
        {
            bool isdelete = false;
            try
            {
             var res=_appDbContext.project.Find(id);
                if (res!= null)
                {
                    _appDbContext.project.Remove(res);
                    _appDbContext.SaveChanges() ;
                    isdelete=true;

                }

            }
            catch (Exception)
            {

                throw;
            }
            return isdelete;
        }

        public bool updateproject(Project pro)
        {
            bool isupdate=false;
            try
            {
               _appDbContext.project.Update(pro);
                _appDbContext.SaveChanges();
                isupdate=true;
            }
            catch (Exception)
            {

                throw;
            }
            return isupdate;
        }

    }
}
