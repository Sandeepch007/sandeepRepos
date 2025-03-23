using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using communitymodels;

namespace communityDal
{
    public class ContactreviewRepository
    {
        private AppDbContext _context;
        public ContactreviewRepository(AppDbContext context)
        {
            _context = context;
        }
        public List<Contact> GetAllReviews()
        {
            List<Contact> _msgs = new List<Contact>();
            try
            {
                _msgs = _context.contact.ToList();
                return _msgs;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool contactpost(Contact cont)
        {
            bool res = false;
            try
            {
                _context.contact.Add(cont);
                _context.SaveChanges();
                res = true;
            }
            catch (Exception)
            {
                res = false;
                throw;
            }
            return res;
        }
    }
}
