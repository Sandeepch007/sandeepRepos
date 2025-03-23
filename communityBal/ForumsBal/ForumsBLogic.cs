using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using communityDal.Forumfile;
using communitymodels.Forumsmodel;


namespace communityBal.ForumsBal
{
    public class ForumsBLogic
    {
        private readonly ForumsRepository _repo;
        public ForumsBLogic(ForumsRepository repo)
        {
            _repo = repo;
        }
        public List<Forum> GetForum()
        {
            List<Forum> list = new List<Forum>();
            try
            {
                 list=_repo.GetAllForums();
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }
        public List<ForumsReply> GetFReply()
        {
            List<ForumsReply>forumsReplies = new List<ForumsReply>();
            try
            {
                forumsReplies = _repo.GetForumsReply();
            }
            catch (Exception)
            {

                throw;
            }
            return forumsReplies;
        }

        public bool postforum(Forum forum)
        {
            bool issave = false;
            try
            {
                _repo.postforum(forum);
                issave = true;
            }
            catch (Exception)
            {

                throw;
            }
            return issave;
        }
        public bool postreply(ForumsReply forumsReply)
        {
            bool issaved = false;
            try
            {
                _repo.postforumsreply(forumsReply);
                issaved = true;

            }
            catch (Exception)
            {

                throw;
            }
            return issaved;
        }

        public bool forumdelete(int id) 
        {
            bool isdelete=false;
            try
            {
                _repo.deleteforums(id);
                isdelete = true;
            }
            catch (Exception)
            {

                throw;
            }
            return isdelete;
        }

        public bool forumsreplydelete(int id)
        {
            bool isdeleted=false;
            try
            {
                _repo.deleteforumsreply(id);
                isdeleted = true;
            }
            catch (Exception)
            {
                throw;
            }
            return isdeleted;
        }
        public bool updateforumsreply(ForumsReply forumsReply)
        {
            bool isupdated = true;
            try
            {
                _repo.updateforumsreply(forumsReply);
                isupdated = true;
            }
            catch (Exception)
            {

                throw;
            }
            return isupdated;
        }

        public bool updatefor(Forum form)
        {
            bool isupdated = true;
            try
            {
                _repo.updateforum(form);
                isupdated = true;
            }
            catch (Exception)
            {

                throw;
            }
            return isupdated;
        }
    }
}
