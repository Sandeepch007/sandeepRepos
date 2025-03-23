using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using communitymodels;
using communitymodels.Forumsmodel;

namespace communityDal.Forumfile
{
    public class ForumsRepository
    {
        private AppDbContext _appDbContext;
        public ForumsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        /// <summary>
        /// to svae the forums
        /// </summary>
        /// <param name="forum"></param>
        /// <returns></returns>
        public bool postforum(Forum forum)
        {
            bool issave=false;
            try
            {
              _appDbContext.forums.Add(forum);
                _appDbContext.SaveChanges();
                issave=true;

            }
            catch (Exception)
            {

                throw;
            }
            return issave;
        }
        public List<Forum> GetAllForums() 
        {
            List<Forum> forums = new List<Forum>();
            try
            {
               forums=(from f in _appDbContext.forums join log in _appDbContext.Logins on f.LoginId equals
                     log.Loginid
                     select(new Forum
                     {
                         Question = f.Question,
                         QuestionId = f.QuestionId,
                         LoginId = f.LoginId,
                         login=new Login
                         {
                             Username=log.Username,

                         }
                     })).ToList();
                
            }
            catch (Exception)
            {

                throw;
            }
            return forums;
        }

        public bool postforumsreply(ForumsReply reply)
        {
            bool ispostt = false;
            try
            {
              _appDbContext.ForumsReply.Add(reply);
                _appDbContext.SaveChanges();
                ispostt=true;
            }
            catch (Exception)
            {

                throw;
            }
            return ispostt;
        }
        public List<ForumsReply> GetForumsReply()
        {
            List<ForumsReply> forumsReplies= new List<ForumsReply>();
            try
            {
                forumsReplies = (from reply in _appDbContext.ForumsReply
                                 join form in _appDbContext.forums on reply.QuestionId equals
                             form.QuestionId
                                 select (new ForumsReply
                                 {
                                     Reply = reply.Reply,
                                     ReplyId = reply.ReplyId,
                                     Forum = new Forum
                                     {
                                         Question = form.Question,
                                         QuestionId = form.QuestionId,
                                         LoginId = form.LoginId,
                                         login = form.login != null
                                 ? new Login
                                 {
                                     Username = form.login.Username
                                 }
                                 : new Login
                                 {
                                     Username = string.Empty
                                 }
                                     }
                                 })).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return forumsReplies;
        }

        public bool deleteforums(int id)
        {
            bool isdeleted = false;
            try
            {
               var forumsid= _appDbContext.forums.Find(id);
                if (forumsid != null) 
                {
                    _appDbContext.forums.Remove(forumsid);
                    _appDbContext.SaveChanges();
                    isdeleted=true;
                }

                
            }
            catch (Exception)
            {

                throw;
            }
            return isdeleted;
        }

        public bool deleteforumsreply(int id)
        {
            bool isdelete= false;
            try
            {
               var reply= _appDbContext.ForumsReply.Find(id);
                if(reply != null)
                {
                    _appDbContext.ForumsReply.Remove(reply);
                    _appDbContext.SaveChanges();
                    isdelete=true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return isdelete;
        }

        public bool updateforumsreply(ForumsReply forumsReply)
        {
            bool isupdate=false;
            try
            {
           
                _appDbContext.ForumsReply.Update(forumsReply);
                _appDbContext.SaveChanges();
                isupdate=true;
                
            }
            catch (Exception)
            {

                throw;
            }
            return isupdate;
        }
        public bool updateforum(Forum forum)
        {
            bool isupdate = false;
            try
            {

                _appDbContext.forums.Update(forum);
                _appDbContext.SaveChanges();
                isupdate = true;

            }
            catch (Exception)
            {

                throw;
            }
            return isupdate;
        }

    }
}
