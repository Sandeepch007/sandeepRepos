using communityBal.ForumsBal;
using communitymodels;
using communitymodels.Forumsmodel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Curdoperations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForumsController : ControllerBase
    {
        private readonly ForumsBLogic _objbal;
        public ForumsController(AppDbContext appDbContext)
        {
            _objbal = new ForumsBLogic(new communityDal.Forumfile.ForumsRepository(appDbContext));
        }
        [HttpGet(Name =("Getforums"))]
        public List<Forum> GetForum()
        {
            List<Forum> list = new List<Forum>();
            try
            {
             list=_objbal.GetForum();

            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }
        [HttpPost(Name = "Forumspost")]
        public string postforum(Forum newForum) 
        {
            bool ispost=false;
            string message=string.Empty;
            try
            {
             ispost=_objbal.postforum(newForum);
                if (ispost) 
                {
                    message = "record is inserted succsessfully..";
                }
                else
                {
                    message = "record is not inserted..";
                }

            }
            catch (Exception)
            {

                throw;
            }
            return message;
        }

        [HttpPost("Forumsreply")]
        public string postforumsreply(ForumsReply Reply)
        {
            string message = string.Empty;
            bool isposted=false;
            try
            {
                isposted=_objbal.postreply(Reply);
                if (isposted)
                {
                    message = "record inserted...";
                }
                else
                {
                    message = "not inserted..";
                }

            }
            catch (Exception)
            {

                throw;
            }
            return message;
        }
        [HttpGet("forumsreply")]
        public List<ForumsReply> GetForumsReplies()
        {
            List<ForumsReply>list = new List<ForumsReply>();
            try
            {
                list = _objbal.GetFReply();
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }
        [HttpDelete("forumsdelete/{id}")]
        public string forumDelete(int id)
        {
            string message = string.Empty;
            bool isdelete=false;
            try
            {
                isdelete=_objbal.forumdelete(id);
                if (isdelete)
                {
                    message = "Record is deleted..";
                }
                else
                {
                    message = "Record is not deleted..";
                }
            }
            catch (Exception)
            {

                throw;
            }
            return message;
        }

        [HttpDelete("deleteforumsreply/{id}")]
        public string deleteforumsreply(int id)
        {
            string message = string.Empty;
            bool isdelete=false;
            try
            {
                isdelete= _objbal.forumsreplydelete(id);
                if (isdelete)
                {
                    message = "record is deleted..";
                }
                else
                {
                    message = "record is not deleted..";
                }
            }
            catch (Exception)
            {

                throw;
            }
            return message;
        }
        [HttpPut("updatereplyforum")]
        public string updatereply(ForumsReply reply) 
        {
            string message=string.Empty;
            bool isupdate=false;
            try
            {
                isupdate=_objbal.updateforumsreply(reply);
                if (isupdate)
                {
                    message = "record is updated..";
                }
                else
                {
                    message = "record is not updated..";
                }

            }
            catch (Exception)
            {

                throw;
            }
            return message;
        }

        [HttpPut(Name ="updateforum")]
        public string updateforum(Forum form)
        {
            string message = string.Empty;
            bool isupdate = false;
            try
            {
                isupdate = _objbal.updatefor(form);
                if (isupdate)
                {
                    message = "record is updated..";
                }
                else
                {
                    message = "record is not updated..";
                }

            }
            catch (Exception)
            {

                throw;
            }
            return message;
        }

    }
}
