using communityBal.ProjectBal;
using communitymodels;
using communitymodels.Projectsmodel;
using Microsoft.AspNetCore.Mvc;

namespace Curdoperations.Controllers
{
    public class ProjectController : Controller
    {
		private readonly ProjectBLogic projectBLogic;
		public ProjectController(AppDbContext context)
		{
			projectBLogic=new ProjectBLogic(new communityDal.ProjectDal.ProjectRepository(context));
		}
		[HttpGet]
        public List<Project> projectlst()
        {
			List<Project> list = new List<Project>();
			try
			{
				list = projectBLogic.prolist();
                return list;
            }
			catch (Exception)
			{

				throw;
			}
			
        }
		[HttpPost]
		public string postproject(Project project) 
		{
			string msg = string.Empty;
			bool ispost=false;
			try
			{
				ispost=projectBLogic.propost(project);
				if (ispost) 
				{
					msg = "record is inserted successfully";
				}
				else
				{
					msg = "record is not inserted succesfully";
				}

			}
			catch (Exception)
			{

				throw;
			}
			return msg;
		}

        [HttpPut]
        public string updateproject(Project project)
        {
            string msg = string.Empty;
            bool isupdate = false;
            try
            {
                isupdate = projectBLogic.proupdate(project);
                if (isupdate)
                {
                    msg = "record is updated successfully";
                }
                else
                {
                    msg = "record is not updated succesfully";
                }

            }
            catch (Exception)
            {

                throw;
            }
            return msg;
        }

        [HttpDelete("{id}")]
        public string deleteproject(int id) 
		{
            string msg = string.Empty;
            bool isdelete = false;
            try
            {
                isdelete = projectBLogic.deletepro(id);
                if (isdelete)
                {
                    msg = "record is deleted successfully";
                }
                else
                {
                    msg = "record is not deleted succesfully";
                }

            }
            catch (Exception)
            {

                throw;
            }
            return msg;
        }
    }
}
