using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using communityDal;
using communitymodels;
using Microsoft.EntityFrameworkCore;

namespace communityBal
{
    public class ContactreviewBlogic
    {
        private readonly ContactreviewRepository _crepo;
        public ContactreviewBlogic(ContactreviewRepository crepo)
        {
            _crepo = crepo;

        }

        public List<Contact> getreviews()
        {
           
            try
            {
                List<Contact> list = new List<Contact>();
                list=_crepo.GetAllReviews();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool contactss(Contact cont)
        {
            try
            {
                return _crepo.contactpost(cont);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
